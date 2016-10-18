using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    class Order
    {
        private Drink _drink;
        private List<DrinkAddition> _drinkAdditionList;
        private string _sugar;
        private string _temperature;
        private const string INITIAL_STRING = "";
        private const int INITIAL_VALUE = -1;

        //constructor
        public Order()
        {
            _drink = new Drink();
            _drinkAdditionList = new List<DrinkAddition>();
            _sugar = INITIAL_STRING;
            _temperature = INITIAL_STRING;
        }

        // set order drink
        public void SetOrderDrink(Drink drink)
        {
            _drink.SetName(drink.GetName());
            _drink.SetPrice(drink.GetPrice());
        }

        //set drink addition
        public void SetDrinkAddition(DrinkAddition drinkAddition)
        {
            _drinkAdditionList.Add(drinkAddition);
        }

        //set price
        public void SetPrice(int price)
        {
            _drink.SetPrice(price);
        }

        //set sugar
        public void SetSugar(string sugar)
        {
            _sugar = sugar;
        }

        //set temperature
        public void SetTemperature(string temperature)
        {
            _temperature = temperature;
        }

        //get drink
        public Drink GetDrink()
        {
            return _drink;
        }

        //get drink name
        public string GetDrinkName()
        {
            return _drink.GetName();
        }

        //get drink price
        public int GetDrinkPrice()
        {
            return _drink.GetPrice();
        }

        //get drink addition list
        public List<DrinkAddition> GetDrinkAddition()
        {
            return _drinkAdditionList;
        }

        //get drink sugar
        public string GetDrinkSugar()
        {
            return _sugar;
        }

        //get drink temperature
        public string GetDrinkTemperature()
        {
            return _temperature;
        }
    }
}
