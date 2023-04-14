namespace PizzaStore
{
    public class EmployeeCatalog 
    {
        #region Instance Fields
        private static List<Employee> _employees = new List<Employee>();
        #endregion

        #region Constructor
        static EmployeeCatalog()
        {
            DefaultEmployees();
        }
        #endregion

        #region Properties
        public static List<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }
        #endregion

        #region Methods
        private static void DefaultEmployees()
        {
            CreateEmployee("Henrik");
            CreateEmployee("Lasse");
            CreateEmployee("Brian");
        }

        // TODO: ændre til void metode.
        public static Employee SearchForEmployee(String name)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.Name.ToLower().Equals(name.ToLower()))
                {
                    return employee;
                }
            }

            return new Employee("Ukendt");
        }

        public static void CreateEmployee(string name)
        {
            Employees.Add(new Employee(name));
        }

        public static string ReadEmployee(int id)
        {
            return Employees[id].Name;
        }

        public static void ReadEmployees()
        {
            String _fullString = "";

            for (int i = 0; i < Employees.Count(); i++)
            {
                int _counter = i;
                ++_counter;
                _fullString += $"{_counter}. {ReadEmployee(i)}\n";
            }

            Console.WriteLine(_fullString);
        }

        public static void Choice()
        {
            Console.WriteLine("Hvad ønsker du at foretage dig?" +
                "\n1. Opret en ny ansat." +
                "\n2. Få en liste over ansatte." +
                "\n3. Opdater ansat." +
                "\n4. Slet en ansat.");

            string choice = Console.ReadLine();

            try
            {
                int id = int.Parse(choice);

                switch (id)
                {
                    case 1:
                        Console.WriteLine("Indtast oplysningerne i følgende rækkefølge.");
                        Console.Write("Navn: ");
                        string employeeName = Console.ReadLine();
                        CreateEmployee(employeeName);
                        break;
                    case 2:
                        ReadEmployees();
                        break;
                    case 3:
                        UpdateEmployee();
                        break;
                    case 4:
                        ReadEmployees();
                        Console.WriteLine("Skriv nummer på den ansatte, som du ønsker at slette.");
                        string readInput = Console.ReadLine();
                        int deletionNumber = int.Parse(readInput);
                        DeleteEmployee(deletionNumber);
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                throw new NotANumberException();
            }
        }

        public static void UpdateEmployee()
        {
            Console.WriteLine("Ønsker du at opdatere en ansat? Ja / Nej");
            var _input = Console.ReadLine();
            if (_input is string)
            {
                _input = _input.ToLower();

                switch (_input)
                {
                    case "ja":
                        EmployeeUpdateChose();
                        break;
                    case "nej":
                        break;
                    default:
                        ErrorHappend();
                        break;
                }
            }
        }

        private static void EmployeeUpdateChose()
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
            ReadEmployees();
            Console.WriteLine("Indtast nummer på den ansatte, som du ønsker at opdatere");
            var _input = Console.ReadLine();
            if (_input is string)
            {
                try
                {
                    int _id = Int32.Parse(_input);
                    --_id;
                    Console.WriteLine();
                    Console.WriteLine("Indtast nyt navn.");
                    var _newName = Console.ReadLine();
                    if (_newName is string)
                    {
                        Employees[_id].Name = _newName;
                        Console.WriteLine();
                    }
                }
                catch 
                {
                    throw new NotANumberException();
                }
            }
        }

        public static void DeleteEmployee(int id)
        {
            --id;
            Employees.Remove(Employees[id]);
        }

        private static void ErrorHappend()
        {
            Console.WriteLine("Der er sket en fejl");
        }
        #endregion
    }
}
