namespace Bank.Domain
{
    /// <summary>
    /// Concrete factory method that creates <see cref="MoneyBack"/> cards.
    /// </summary>
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Creates a new <see cref="MoneyBack"/> instance.
        /// </summary>
        /// <returns>A <see cref="MoneyBack"/> as <see cref="ICreditCard"/>.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}