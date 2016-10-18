using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    enum Temperature
    {
        Normal,
        Less,
        No,
        Hot
    }

    enum Sugar
    {
        Normal,
        Half,
        Less,
        No
    }

    class DrinkModel
    {
        private List<Drink> _drinkList;
        private List<Order> _orderList;
        private List<DrinkAddition> _drinkAdditionList;
        private List<List<Order>> _ordersList;
        private Update _update;
        private const int JASMINE_GREEN_TEA_PRICE = 20;
        private const int A_SHAME_BLACK_TEA_PRICE = 25;
        private const int MOUNTAIN_GREEN_TEA_PRICE = 40;
        private const int IRON_GODDESS_VARIETY_PRICE = 50;
        private const int WOO_LONG_GREEN_TEA_PRICE = 30;
        private const string JASMINE_GREEN_TEA_NAME = "茉莉綠茶";
        private const string A_SHAME_BLACK_TEA_NAME = "阿薩姆紅茶";
        private const string MOUNTAIN_GREEN_TEA_NAME = "高山青茶";
        private const string IRON_GODDESS_VARIETY_NAME = "鐵觀音";
        private const string WOO_LONG_GREEN_TEA_NAME = "烏龍青茶";
        private const int BUBBLE_PRICE = 5;
        private const int COCONUT_JELLY_PRICE = 5;
        private const int GRASS_JELLY_PRICE = 10;
        private const int PUDDING_PRICE = 10;
        private const string BUBBLE_NAME = "珍珠";
        private const string COCONUT_JELLY_NAME = "椰果";
        private const string GRASS_JELLY_NAME = "仙草";
        private const string PUDDING_NAME = "布丁";

        //default constructor
        public DrinkModel()
        {
            Initialize();
        }

        //initialize drink model
        private void Initialize()
        {
            _update = new Update();
            InitializeDrinkList();
            InitializeOrderList();
            InitializeDrinkAdditionList();
            InitializeOrdersList();
        }

        //initialize drink list
        private void InitializeDrinkList()
        {
            _drinkList = new List<Drink>();
            AddDrinkList(JASMINE_GREEN_TEA_NAME, JASMINE_GREEN_TEA_PRICE);
            AddDrinkList(A_SHAME_BLACK_TEA_NAME, A_SHAME_BLACK_TEA_PRICE);
            AddDrinkList(MOUNTAIN_GREEN_TEA_NAME, MOUNTAIN_GREEN_TEA_PRICE);
            AddDrinkList(IRON_GODDESS_VARIETY_NAME, IRON_GODDESS_VARIETY_PRICE);
            AddDrinkList(WOO_LONG_GREEN_TEA_NAME, WOO_LONG_GREEN_TEA_PRICE);
        }

        //add drinks into drink list
        private void AddDrinkList(string name, int price)
        {
            Drink drink = new Drink();
            drink.SetName(name);
            drink.SetPrice(price);
            _drinkList.Add(drink);
        }

        //initialize column of datatable
        private void InitializeColumn(DataTable dataTable, string columnName)
        {
            dataTable.Columns.Add(new DataColumn(columnName));
        }

        //initialize order list
        private void InitializeOrderList()
        {
            _orderList = new List<Order>();
        }

        //initialize drink addition list
        private void InitializeDrinkAdditionList()
        {
            _drinkAdditionList = new List<DrinkAddition>();
            AddDrinkAdditionList(BUBBLE_NAME, BUBBLE_PRICE);
            AddDrinkAdditionList(COCONUT_JELLY_NAME, COCONUT_JELLY_PRICE);
            AddDrinkAdditionList(GRASS_JELLY_NAME, GRASS_JELLY_PRICE);
            AddDrinkAdditionList(PUDDING_NAME, PUDDING_PRICE);
        }

        //add drink addition into a list
        private void AddDrinkAdditionList(string name, int price)
        {
            DrinkAddition drinkAddition = new DrinkAddition();
            drinkAddition.SetName(name);
            drinkAddition.SetPrice(price);
            _drinkAdditionList.Add(drinkAddition);
        }

        // initialize orders list
        private void InitializeOrdersList()
        {
            _ordersList = new List<List<Order>>();
        }

        // update drink in order datagridview
        public void UpdateDrinkInOrderDataGridView(int rowIndex)
        {
            _update.UpdateDrinkInOrderList(rowIndex, _drinkList, _orderList);
        }

        //update drink addition in order datagridview
        public void UpdateDrinkAdditionInOrderDataGridView(int rowIndex, int orderIndex)
        {
            _update.UpdateDrinkAdditionInOrderList(rowIndex, orderIndex, _drinkAdditionList, _orderList);
        }

        //update addition in order table
        public string UpdateAdditionInOrderTable(int rowIndex)
        {
            return _update.UpdateAdditionString(rowIndex, _orderList);
        }

        //update order drink in order datagridview
        public void UpdateOrderDrinkInOrderDataGridView(int rowIndex)
        {
            _update.UpdateOrderList(rowIndex, _orderList);
        }

        //click sugar button
        public void ClickSugarButton(Sugar sugar, int orderIndex)
        {
            _update.UpdateSugarInOrderList(sugar, orderIndex, _orderList);
        }

        //click temperature button
        public void ClickTemperatureButton(Temperature temperature, int orderIndex)
        {
            _update.UpdateTemperatureInOrderList(temperature, orderIndex, _orderList);
        }

        //click pay button
        public void ClickPayButton()
        {
            _ordersList.Add(_orderList);
            _orderList = new List<Order>();
        }

        //check addition in the order
        public bool CheckAdditionInOrderList(int orderRowIndex, int additionRowIndex)
        {
            return _update.HasAddition(orderRowIndex, additionRowIndex, _orderList);
        }

        //check sugar and temperature is done
        public bool IsNotEmpty()
        {
            return _update.HasSugarAndTemperature(_orderList);
        }

        //get number of drink
        public int GetNumberOfDrinks()
        {
            return _drinkList.Count;
        }

        // get drink
        public Drink GetDrink(int count)
        {
            return _drinkList[count];
        }

        //get number of drink addition
        public int GetNumberOfDrinkAddition()
        {
            return _drinkAdditionList.Count;
        }

        //get drink addition
        public DrinkAddition GetDrinkAddition(int count)
        {
            return _drinkAdditionList[count];
        }

        //get number of order drinks
        public int GetNumberOfOrderDrinks()
        {
            return _orderList.Count;
        }

        //get order drink
        public Order GetOrderDrink(int count)
        {
            return _orderList[count];
        }

        //get total price
        public int GetTotalPrice()
        {
            int price = 0;

            for (int count = 0; count < _orderList.Count; count++)
            {
                price = price + _orderList[count].GetDrinkPrice();
            }
            return price;
        }
    }
}
