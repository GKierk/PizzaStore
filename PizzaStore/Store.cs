namespace PizzaStore
{
    public class Store
    {
        #region Instance Fields
        private string _name;
        #endregion

        #region Constructor
        public Store(string name)
        {
            _name = name;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }
        #endregion

        #region Methods
        public void Run()
        {
            UserDialog.RunDialog();
        }
        #endregion
    }
}
