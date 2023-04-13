namespace PizzaStore
{
    public static class Order
    {
        #region Instance Fields

        #endregion

        #region Constructor
        static Order()
        {
        }
        #endregion

        #region Properties

        #endregion

        #region Methods
        public static void CreateOrder(Customer customerName)
        {
            foreach (Customer id in CustomerCatalog.Customers)
            {
                if (id.Equals(customerName))
                {
                    MenuCatalog.ReadPizzas();
                    Console.WriteLine("Hvilke pizza ønsker du at tilføje til din ordre? (Skriv navnet)");
                    string input = Console.ReadLine();
                    if (input is string)
                    {
                        customerName.AddPizzaToOrder(input);
                    }
                }
            }
        }

        public static void ReadOrder(Customer customerName) 
        {
            string message = "";
            message += "Du har bestilt det følgelnde:\n";

            foreach(Pizza pizza in customerName.CurrentOrder)
            {
                message += $"\t{pizza.ToString()}\n";
            }
        }

        public static double CalcultateTotal(Customer customerName)
        {
            double _total = 0;

            foreach(MenuItem i in customerName.CurrentOrder)
            {
                _total += i.Price * Data.Tax;
            }

            return _total * Data.DeliveryFee;
        }
        #endregion
    }
}
