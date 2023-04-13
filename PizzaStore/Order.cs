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
        public static void CreateOrder(string customerName)
        {
            foreach (Customer id in CustomerCatalog.Customers)
            {
                if (id.Name.ToLower().Equals(customerName))
                {
                    MenuCatalog.ReadPizzas();
                    Console.WriteLine("Hvilke pizza ønsker du at tilføje til din ordre? (Skriv navnet)");
                    string input = Console.ReadLine();
                    if (input is string)
                    {
                        id.AddPizzaToOrder(input);
                    }
                }
            }
        }

        public static void ReadOrder(string customerName) 
        {
            string message = "";
            message += "Du har bestilt det følgelnde:\n";
            foreach (Customer id in CustomerCatalog.Customers)
            {
                if (id.Name.ToLower().Equals(customerName))
                {
                    foreach (Pizza pizza in id.CurrentOrder)
                    {
                        message += $"\t{pizza.ToString()}\n";
                    }
                }
            }

            Console.WriteLine($"Din totale prise inklusiv levering bliver {CalcultateTotal(customerName)} kr.");

        }

        public static double CalcultateTotal(string customerName)
        {
            double _total = 0;
            
            foreach(Customer id in CustomerCatalog.Customers)
            {
                if (id.Name.ToLower().Equals(customerName))
                {
                    foreach(MenuItem item in id.CurrentOrder)
                    {
                        _total += item.Price * Data.Tax;
                    }
                }
            }

            return _total + Data.DeliveryFee;
        }
        #endregion
    }
}
