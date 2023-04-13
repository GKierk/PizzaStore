﻿namespace PizzaStore
{
    public static class CustomerCatalog
    {
        #region Instance Fields
        private static List<Customer> _customers = new List<Customer>();
        #endregion

        #region Constructor
        static CustomerCatalog()
        {
            DefaultCustomers();
        }
        #endregion

        #region Properties
        public static List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        #endregion

        #region Methods
        private static void DefaultCustomers()
        {
            CreateCustomer("Bo");
            CreateCustomer("Erik");
            CreateCustomer("Lars");
        }

        // TODO: ændre til void metode.
        public static Customer SearchForCustomer(String name)
        {
            foreach (Customer customer in Customers)
            {
                if (customer.Name.ToLower().Equals(name.ToLower()))
                {
                    return customer;
                }
            }

            return new Customer("Ukendt");
        }

        public static void CreateCustomer(string name)
        {
            Customers.Add(new Customer(name));
        }

        public static string ReadCustomer(int id)
        {
            return Customers[id].Name;
        }

        public static void ReadCustomers()
        {
            String _fullString = "";

            for (int i = 0; i < Customers.Count(); i++)
            {
                int _counter = i;
                ++_counter;
                _fullString += $"{_counter}. {ReadCustomer(i)}\n";
            }

            Console.WriteLine(_fullString);
        }

        public static void UpdateCustomer()
        {
            Console.WriteLine("Ønsker du at opdatere en kunde? Ja / Nej");
            var _input = Console.ReadLine();
            if (_input is string)
            {
                _input = _input.ToLower();

                switch (_input)
                {
                    case "ja":
                        CustomerUpdateChose();
                        break;
                    case "nej":
                        break;
                    default:
                        ErrorHappend();
                        break;
                }
            }
        }

        private static void CustomerUpdateChose()
        {
            Console.WriteLine("Hvad vil du gerne opdatere?\nNavnet");
            var input = Console.ReadLine();
            if (input is string)
            {
                input = input.ToLower();

                switch (input)
                {
                    case "navnet":
                        Console.WriteLine();
                        ChangeName();
                        break;
                    default:
                        Console.WriteLine();
                        ErrorHappend();
                        break;
                }
            }
        }

        private static void ChangeName()
        {
            ReadCustomers();
            Console.WriteLine("Indtast nummer på den kunde, som du ønsker at opdatere");
            var _input = Console.ReadLine();
            if (_input is string)
            {
                int _id = Int32.Parse(_input);
                --_id;
                Console.WriteLine();
                Console.WriteLine("Indtast nyt navn.");
                var _newName = Console.ReadLine();
                if (_newName is string)
                {
                    Customers[_id].Name = _newName;
                    Console.WriteLine();
                }
            }
        }

        public static void DeleteCustomer(int id)
        {
            --id;
            Customers.Remove(Customers[id]);
        }

        private static void ErrorHappend()
        {
            Console.WriteLine("Der er sket en fejl");
        }
        #endregion
    }
}
