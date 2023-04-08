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
            set { _name = value; }
        }

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        #endregion

        #region Methods
        public override string ToString() => $"{Name}, størrelse {Size}, pris {Price} kr.";
        #endregion
    }
}
