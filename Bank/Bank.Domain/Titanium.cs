namespace Bank.Domain
{
    /// <summary>
    /// A Titanium credit card implementation.
    /// Provides the card type, credit limit and annual charge for Titanium cards.
    /// </summary>
    public class Titanium : ICreditCard
    {
        /// <inheritdoc />
        public string GetCardType()
        {
            return "Titanium Edge";
        }

        /// <inheritdoc />
        public int GetCreditLimit()
        {
            return 25000;
        }

        /// <inheritdoc />
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}