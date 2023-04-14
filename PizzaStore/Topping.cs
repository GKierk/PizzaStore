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
            DefaultToppings();
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

        #region Methods
        private void DefaultToppings()
        {
            AddNewTopping("Ost", 8);
            AddNewTopping("Gorgonzola", 12);
            AddNewTopping("Tomat Sovs", 5);
        }

        public void AddNewTopping(string toppingName, int toppingPrice)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
