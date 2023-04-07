using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza : MenuItem
    {
        #region Constructor
        public Pizza(string name, string size, int price) : base(name, size, price)
        {

        }
        #endregion


    }
}
