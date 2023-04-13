namespace PizzaStore
{
    public class Customer : Person
    {
        #region Instance Fields
        private List <MenuItem> _currentOrders = new List <MenuItem> ();
        #endregion

        #region Constructor
        public Customer(string name) : base(name)
        {

        }
        #endregion

        #region Properties
        public List<MenuItem> CurrentOrder
        { 
            get { return _currentOrders; }
            set { _currentOrders = value; }
        }
        #endregion

        #region Methods
        public void ReadOrder()
        {
            string output = "Din ordre består af følgende: \n";

            foreach(Pizza pizza in CurrentOrder)
            {
                output += $"\t{pizza.Name}\n";
            }

            Console.WriteLine(output);
        }

        public void AddPizzaToOrder(string pizzaName)
        {
            foreach(Pizza pizza in MenuCatalog.Pizzas)
            {
                if(pizza.Name.Equals(pizzaName))
                {
                    CurrentOrder.Add(pizza);
                }
            }
        }
        #endregion
    }
}
