namespace PizzaStore
{
    public static class UserDialog
    {
        #region Instance Fields

        #endregion

        #region Constructor
        static UserDialog()
        {

        }
        #endregion

        #region Properties

        #endregion

        #region Methods
        public static void RunDialog()
        {
            bool _runProgram = true;


            while (_runProgram)
            {
                Console.WriteLine("Skriv \"Enter\" for at fortsætte, eller skriv \"Q\" for at afslutte og afslut med \"Enter\"");
                string _input = Console.ReadLine();
                if (_input is string)
                {
                    if (_input.ToLower().Equals("q"))
                    {
                        _runProgram = false;
                    }
                    else
                    {
                        Console.WriteLine("1. Ansat. \n2. Kunde.");
                        var _person = Console.ReadLine();
                        if (_person is string)
                        {
                            int _id = int.Parse(_person);

                            switch (_id)
                            {
                                case 1:
                                    SwitchToEmployee();
                                    break;
                                case 2:
                                    SwitchToCustomer();
                                    break;
                            }
                        }
                    }
                }
                
            }
        }

        public static void SwitchToEmployee()
        {
            Console.WriteLine("Hvad ønsker du at foretage dig?" +
                "\n1. Indstillinger ift. Pizzaer." +
                "\n2. Indstillinger ift. Ansatte." +
                "\n3. Indstillinger ift. kunder.");
            var _input = Console.ReadLine();
            int _id = int.Parse(_input);
            switch (_id)
            {
                case 1:
                    MenuCatalog.Choice();
                    break;
                case 2:
                    EmployeeCatalog.Choice();
                    break;
                case 3:
                    CustomerCatalog.Choice();
                    break;
                default:
                    break;
            }
        }

        public static void SwitchToCustomer()
        {
            Console.WriteLine("Hvad ønsker du at foretage dig?" +
                "\n1. En menu over pizzaer." +
                "\n2. Opdater kundeoplysninger.");
            var _input = Console.ReadLine();
            int _id = int.Parse(_input);
            switch (_id)
            {
                case 1:
                    Console.WriteLine("Indtast kunde navn.");
                    string _person = Console.ReadLine().ToLower();
                    Order.CreateOrder(_person);
                    Order.ReadOrder(_person);
                    break;
                case 2:
                    CustomerCatalog.UpdateCustomer();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
