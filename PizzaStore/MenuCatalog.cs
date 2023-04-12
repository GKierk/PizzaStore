﻿using PizzaStore;
using System.Diagnostics.Metrics;

namespace PizzaStore
{
    public static class MenuCatalog
    {
        #region Instance Fields
        private static List<Pizza> _pizzas = new List<Pizza>();
        #endregion

        #region Constructor
        static MenuCatalog()
        {
            DefaultPizzas();
        }
        #endregion

        #region Properties
        public static List<Pizza> Pizzas
        {
            get { return _pizzas; }
            set { _pizzas = value; }
        }
        #endregion

        #region Methods
        private static void DefaultPizzas()
        {
            CreatePizza("Magaritha", "Medium", 69);
            CreatePizza("Hawai", "Medium", 89);
            CreatePizza("Pepperoni", "Medium", 89);
        }

        // TODO: ændre til void metode.
        public static Pizza SearchForPizza(String name)
        {
            foreach(Pizza pizza in Pizzas)
            {
                if (pizza.Name.ToLower().Equals(name.ToLower()))
                {
                    return pizza;
                }
            }

            return new Pizza("Ukendt", "Ukendt", 0);
        }

        public static void CreatePizza(string pizzaName, string pizzaSize, int pizzaPrice)
        {
            _pizzas.Add(new Pizza(pizzaName, pizzaSize, pizzaPrice));
        }

        public static Pizza ReadPizza(int id)
        {
            return Pizzas[id];
        }

        public static void ReadPizzas()
        {
            String _fullString = "";
            
            for(int i = 0; i < Pizzas.Count(); i++)
            {
                int _counter = i;
                ++_counter;
                _fullString += $"{_counter}. {ReadPizza(i)}\n";
            }

            Console.WriteLine(_fullString);
        }

        public static void UpdatePizza()
        {
            Console.WriteLine("Ønsker du at opdatere en pizza? Ja / Nej");
            var _input = Console.ReadLine();
            if(_input is string)
            {
                _input = _input.ToLower();

                switch(_input)
                {
                    case "ja":
                        PizzaUpdateChose();
                        break;
                    case "nej":
                        break;
                    default:
                        ErrorHappend();
                        break;
                }
            }
        }

        private static void PizzaUpdateChose()
        {
            Console.WriteLine("Hvad vil du gerne opdatere?\nNavnet/Size/Prisen");
            var input = Console.ReadLine();
            if(input is string)
            {
                input = input.ToLower();

                switch(input)
                {
                    case "navnet":
                        Console.WriteLine();
                        ChangePizzaName();
                        break;
                    case "size":
                        Console.WriteLine();
                        ChangePizzaSize();
                        break;
                    case "prisen":
                        Console.WriteLine();
                        ChangePizzaPrice();
                        break;
                    default:
                        Console.WriteLine();
                        ErrorHappend();
                        break;
                }
            }
        }

        private static void ChangePizzaName()
        {
            ReadPizzas();
            Console.WriteLine("Indtast nummer på den pizza, som du ønsker at opdatere");
            var _input = Console.ReadLine(); //as string;
            if (_input is string)
            {
                int _id = Int32.Parse(_input);
                --_id;
                Console.WriteLine();
                Console.WriteLine("Indtast nyt navn.");
                var _newName = Console.ReadLine();
                if(_newName is string)
                {
                    _pizzas[_id].Name = _newName;
                    Console.WriteLine();
                }
            }
        }

        private static void ChangePizzaSize()
        {
            ReadPizzas();
            Console.WriteLine("Indtast nummer på den pizza, som du ønsker at opdatere");
            var _input = Console.ReadLine(); //as string;
            if (_input is string)
            {
                int _id = Int32.Parse(_input);
                --_id;
                Console.WriteLine();
                Console.WriteLine("Indtast ny størrelse.");
                var _newSize = Console.ReadLine();
                if (_newSize is string)
                {
                    _pizzas[_id].Size = _newSize;
                    Console.WriteLine();
                }
            }
        }

        private static void ChangePizzaPrice()
        {
            ReadPizzas();
            Console.WriteLine("Indtast nummer på den pizza, som du ønsker at opdatere");
            var _input = Console.ReadLine(); //as string;
            if (_input is string)
            {
                int _id = Int32.Parse(_input);
                --_id;
                Console.WriteLine();
                Console.WriteLine("Indtast ny pris.");
                var _newPrice = Console.ReadLine();
                if (_newPrice is string)
                {
                    int _newPizzaPrice = Int32.Parse(_newPrice);
                    _pizzas[_id].Price = _newPizzaPrice;
                    Console.WriteLine();
                }
            }
        }

        public static void DeletePizzza(int id)
        {
            --id;
            Pizzas.Remove(Pizzas[id]);
        }

        private static void ErrorHappend()
        {
            Console.WriteLine("Der er sket en fejl");
        }
        #endregion
    }
}