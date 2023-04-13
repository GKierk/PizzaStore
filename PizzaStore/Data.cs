namespace PizzaStore
{
    public static class Data
    {
        #region Instance Fields
        private static double _tax = 1.25;
        private static double _deliveryFee = 40.00;
        #endregion

        #region Constructor
        static Data()
        {

        }
        #endregion

        #region Properties
        public static double Tax
        {
            get { return _tax; }
        }

        public static double DeliveryFee
        {
            get { return _deliveryFee; }
        }
        #endregion
    }
}