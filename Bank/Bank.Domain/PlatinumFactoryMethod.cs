namespace Bank.Domain
{
    /// <summary>
    /// Concrete factory method that creates <see cref="Platinum"/> cards.
    /// </summary>
    public class PlatinumFactoryMethod: CreditCardFactoryMethod
    {
        /// <summary>
        /// Creates a new <see cref="Platinum"/> instance.
        /// </summary>
        /// <returns>A <see cref="Platinum"/> as <see cref="ICreditCard"/>.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}