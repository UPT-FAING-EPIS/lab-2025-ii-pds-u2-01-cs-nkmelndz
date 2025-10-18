namespace Bank.Domain
{
    /// <summary>
    /// Base class for the Factory Method pattern. Subclasses override <see cref="MakeProduct"/>
    /// to create concrete <see cref="ICreditCard"/> instances.
    /// </summary>
    public abstract class CreditCardFactoryMethod
    {
        /// <summary>
        /// Factory method to be implemented by concrete factories.
        /// </summary>
        /// <returns>A new <see cref="ICreditCard"/> instance.</returns>
        protected abstract ICreditCard MakeProduct();

        // Also note that The Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
        /// <summary>
        /// Creates a product by delegating to <see cref="MakeProduct"/> and returns it to the caller.
        /// </summary>
        /// <returns>A new <see cref="ICreditCard"/> instance.</returns>
        public ICreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            ICreditCard creditCard = this.MakeProduct();
            //Return the Object to the Client
            return creditCard;
        }
    }
}