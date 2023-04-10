namespace PizzaStore
{
    public abstract class Person
    {
        #region Instance Fields
        string _name;
        #endregion

        #region Constructor
        public Person(string name)
        {
            _name = name;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
    }
}
