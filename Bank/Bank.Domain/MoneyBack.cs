namespace Bank.Domain
{
    /// <summary>
    /// A MoneyBack credit card implementation.
    /// Provides the card type, credit limit and annual charge for MoneyBack cards.
    /// </summary>
    public class MoneyBack : ICreditCard
    {
        /// <inheritdoc />
        public string GetCardType()
        {
            return "MoneyBack";
        }

        /// <inheritdoc />
        public int GetCreditLimit()
        {
            return 15000;
        }

        /// <inheritdoc />
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}