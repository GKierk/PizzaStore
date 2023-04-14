namespace PizzaStore
{
    public class NotANumberException : Exception
    {
        public NotANumberException() : base("Du har indtastet noget, som ikke er et tal.") { }

        public NotANumberException(string message) : base(message) { }
    }
}
