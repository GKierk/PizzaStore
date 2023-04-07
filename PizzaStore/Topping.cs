namespace PizzaStore
{
    public class Topping
    {
        #region Instance Fields
        private string _name;
        private int _price;
        #endregion

        #region Constructor
        public Topping(string name, int price)
        {
            _name = name;
            _price = price;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Price
        {
            get { return _price; }
        }
        #endregion
    }
}
