using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    class Update
    {
        private const string NORMAL_SUGAR = "正常";
        private const string HALF_SUGAR = "半糖";
        private const string LESS_SUGAR = "微糖";
        private const string NO_SUGAR = "無糖";
        private const string NORMAL_ICE = "正常";
        private const string HOT = "溫熱";
        private const string LESS_ICE = "少冰";
        private const string NO_ICE = "去冰";
        private const string SPLIT = "、";

        //default constructor
        public Update()
        {
            
        }

        //update drink in order list
        public void UpdateDrinkInOrderList(int rowIndex, List<Drink> drinkList, List<Order> orderList)
        {
            Order order = new Order();
            order.SetOrderDrink(drinkList[rowIndex]);
            orderList.Add(order);
        }

        //update drink addition in order list
        public void UpdateDrinkAdditionInOrderList(int rowIndex, int orderIndex, List<DrinkAddition> drinkAdditionList, List<Order> orderList)
        {
            DrinkAddition drinkAddition = new DrinkAddition();
            drinkAddition = drinkAdditionList[rowIndex];
            orderList[orderIndex].SetDrinkAddition(drinkAddition);
            orderList[orderIndex].SetPrice((orderList[orderIndex].GetDrinkPrice() + drinkAddition.GetPrice()));
        }

        //update drink addition string
        public string UpdateAdditionString(int rowIndex, List<Order> orderList)
        {
            string addition = "";
            List<DrinkAddition> drinkAddition = orderList[rowIndex].GetDrinkAddition();

            for (int count = 0; count < drinkAddition.Count; count++)
            {
                if (count != 0)
                {
                    addition = addition + SPLIT;
                }
                addition = addition + drinkAddition[count].GetName();
            }
            return addition;
        }

        //update order list
        public void UpdateOrderList(int rowIndex, List<Order> orderList)
        {
            orderList.RemoveAt(rowIndex);
        }

        //update sugar
        public void UpdateSugarInOrderList(Sugar sugar, int orderIndex, List<Order> orderList)
        {
            switch (sugar)
            {
                case Sugar.Normal:
                    UpdateSugarInOrderDataGridView(NORMAL_SUGAR, orderIndex, orderList);
                    break;
                case Sugar.Half:
                    UpdateSugarInOrderDataGridView(HALF_SUGAR, orderIndex, orderList);
                    break;
                case Sugar.Less:
                    UpdateSugarInOrderDataGridView(LESS_SUGAR, orderIndex, orderList);
                    break;
                case Sugar.No:
                    UpdateSugarInOrderDataGridView(NO_SUGAR, orderIndex, orderList);
                    break;
            }
        }

        //update sugar in order datagridview
        private void UpdateSugarInOrderDataGridView(string sugar, int orderIndex, List<Order> orderList)
        {
            UpdateSugarInOrderList(sugar, orderIndex, orderList);
        }

        //update sugar in order list
        private void UpdateSugarInOrderList(string sugar, int orderIndex, List<Order> orderList)
        {
            orderList[orderIndex].SetSugar(sugar);
        }

        //update temperature
        public void UpdateTemperatureInOrderList(Temperature temperature, int orderIndex, List<Order> orderList)
        {
            switch (temperature)
            {
                case Temperature.Normal:
                    UpdateTemperatureInOrderDataGridView(NORMAL_ICE, orderIndex, orderList);
                    break;
                case Temperature.Hot:
                    UpdateTemperatureInOrderDataGridView(HOT, orderIndex, orderList);
                    break;
                case Temperature.Less:
                    UpdateTemperatureInOrderDataGridView(LESS_ICE, orderIndex, orderList);
                    break;
                case Temperature.No:
                    UpdateTemperatureInOrderDataGridView(NO_ICE, orderIndex, orderList);
                    break;
            }
        }

        //update temperature in order datagridview
        private void UpdateTemperatureInOrderDataGridView(string temperature, int orderIndex, List<Order> orderList)
        {
            UpdateTemperatureInOrderList(temperature, orderIndex, orderList);
        }

        //update temperature in order list
        private void UpdateTemperatureInOrderList(string temperature, int orderIndex, List<Order> orderList)
        {
            orderList[orderIndex].SetTemperature(temperature);
        }

        //check addition in the order
        public bool HasAddition(int orderRowIndex, int additionRowIndex, List<Order> orderList)
        {
            bool hasAddition = false;
            int numberOfAddition;
            if (orderList.Count != 0)
            {
                numberOfAddition = orderList[orderRowIndex].GetDrinkAddition().Count;

                for (int count = 0; count < numberOfAddition; count++)
                {
                    if (orderList[orderRowIndex].GetDrinkAddition()[count].GetIndex() == additionRowIndex)
                        hasAddition = true;
                }
            }
            return hasAddition;
        }

        //check sugar and temperature is done
        public bool HasSugarAndTemperature(List<Order> orderList)
        {
            bool done = true;
            for (int count = 0; count < orderList.Count; count++)
            {
                if (orderList[count].GetDrinkSugar() == "")
                {
                    done = false;
                    break;
                }
                else if (orderList[count].GetDrinkTemperature() == "")
                {
                    done = false;
                    break;
                }
            }
            if (orderList.Count == 0)
                done = false;
            return done;
        }
    }
}
