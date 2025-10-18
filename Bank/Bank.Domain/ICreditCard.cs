namespace Bank.Domain
{
    /// <summary>
    /// Represents a credit card with common operations.
    /// Implementations provide the card type, credit limit and annual charge.
    /// </summary>
    public interface ICreditCard
    {
        /// <summary>
        /// Gets the display name of the credit card type.
        /// </summary>
        /// <returns>The card type name (for example, "MoneyBack").</returns>
        string GetCardType();

        /// <summary>
        /// Gets the credit limit for this card.
        /// </summary>
        /// <returns>An integer representing the credit limit in the local currency.</returns>
        int GetCreditLimit();

        /// <summary>
        /// Gets the annual charge for this card.
        /// </summary>
        /// <returns>An integer representing the annual charge in the local currency.</returns>
        int GetAnnualCharge();
    }
}