using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    class Program
    {
        //main function
        static void Main(string[] args)
        {
            Form ezDrink = new EzDrinkForm();
            Application.Run(ezDrink);
        }
    }
}
