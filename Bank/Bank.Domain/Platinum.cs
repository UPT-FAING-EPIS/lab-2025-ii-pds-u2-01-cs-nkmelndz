namespace Bank.Domain
{
    /// <summary>
    /// A Platinum credit card implementation.
    /// Provides the card type, credit limit and annual charge for Platinum cards.
    /// </summary>
    public class Platinum : ICreditCard
    {
        /// <inheritdoc />
        public string GetCardType()
        {
            return "Platinum Plus";
        }

        /// <inheritdoc />
        public int GetCreditLimit()
        {
            return 35000;
        }

        /// <inheritdoc />
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}