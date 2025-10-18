namespace Bank.Domain
{
    /// <summary>
    /// Concrete factory method that creates <see cref="Titanium"/> cards.
    /// </summary>
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Creates a new <see cref="Titanium"/> instance.
        /// </summary>
        /// <returns>A <see cref="Titanium"/> as <see cref="ICreditCard"/>.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}