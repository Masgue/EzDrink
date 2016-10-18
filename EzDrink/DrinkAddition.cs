using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    class DrinkAddition
    {
        private string _name;
        private int _price;
        private int _index;
        private static int _numberOfDrinkAddition = 0;
        private const string INITIAL_NAME = "Unknown";
        private const int INITIAL_PRICE = -1;

        //default constructor
        public DrinkAddition()
        {
            _name = INITIAL_NAME;
            _price = INITIAL_PRICE;
            _index = _numberOfDrinkAddition;
            _numberOfDrinkAddition++;
        }

        //constructor
        public DrinkAddition(string name, int price)
        {
            _name = name;
            _price = price;
            _index = _numberOfDrinkAddition;
            _numberOfDrinkAddition++;
        }

        //get name of drinks addition
        public string GetName()
        {
            return _name;
        }

        //set name of drinks addition
        public void SetName(string changedName)
        {
            _name = changedName;
        }

        //get price of drinks addition
        public int GetPrice()
        {
            return _price;
        }

        //get addition index
        public int GetIndex()
        {
            return _index;
        }

        //set price of drinks addition
        public void SetPrice(int changedPrice)
        {
            _price = changedPrice;
        }
    }
}
