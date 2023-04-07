using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public abstract class MenuItem
    {
        #region Instance Fields
        private string _name;
        private string _size;
        private int _price;
        #endregion

        #region Constructor
        public MenuItem(string name, string size, int price)
        {
            _name = name;
            _size = size;
            _price = price;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public string Size
        {
            get { return _size; }
        }

        public int Price
        {
            get { return _price; }
        }
        #endregion

        #region Methods
        public override string ToString() => $"{Name} ({Size} {Price})";
        #endregion
    }
}
