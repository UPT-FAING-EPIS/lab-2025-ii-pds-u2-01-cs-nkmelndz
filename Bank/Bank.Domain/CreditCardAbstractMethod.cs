namespace Bank.Domain
{
    public abstract class CreditCardFactoryMethod
    {
        protected abstract ICreditCard MakeProduct();
        // Also note that The Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
        public ICreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            ICreditCard creditCard = this.MakeProduct();
            //Return the Object to the Client
            return creditCard;
        }
    }
}