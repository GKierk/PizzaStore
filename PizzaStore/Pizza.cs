/**
 * Edited from previous exercise UML 1 by Gabriel H. Kierkegaard.
 **/
namespace PizzaStore
{
    public class Pizza : MenuItem
    {
        #region Instance Fields
        List<Topping> _toppings = new List<Topping>();
        #endregion

        #region Constructor
        public Pizza(string name, string size, int price) : base(name, size, price)
        {

        }
        #endregion

        public void AddTopping()
        {
            throw new NotImplementedException();
        }
    }
}
