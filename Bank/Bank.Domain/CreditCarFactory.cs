namespace Bank.Domain
{
    /// <summary>
    /// A simple static factory for creating <see cref="ICreditCard"/> instances by type name.
    /// </summary>
    public class CreditCardFactory
    {
        /// <summary>
        /// Returns an <see cref="ICreditCard"/> implementation matching the provided cardType.
        /// </summary>
        /// <param name="cardType">A string identifying the desired card type (e.g. "MoneyBack").</param>
        /// <returns>An instance of <see cref="ICreditCard"/> or <c>null</c> if the type is unknown.</returns>
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard? cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails; 
        }
    }
}