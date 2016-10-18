using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    class Drink
    {
        private string _name;
        private int _price;
        private const string INITIAL_NAME = "Unknown";
        private const int INITIAL_PRICE = -1;
        
        //default constructor
        public Drink()
        {
            _name = INITIAL_NAME;
            _price = INITIAL_PRICE;
        }

        //constructor
        public Drink(string name, int price)
        {
            _name = name;
            _price = price;
        }

        //get name of drinks
        public string GetName()
        {
            return _name;
        }

        //set name of drinks
        public void SetName(string changedName)
        {
            _name = changedName;
        }

        //get price of drinks
        public int GetPrice()
        {
            return _price;
        }

        //set price of drinks
        public void SetPrice(int changedPrice)
        {
            _price = changedPrice;
        }
    }
}
