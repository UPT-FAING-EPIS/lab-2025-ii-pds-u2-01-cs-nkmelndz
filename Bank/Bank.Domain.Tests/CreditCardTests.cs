using Bank.Domain;
using NUnit.Framework;

namespace Bank.Domain.Tests
{
    public class CreditCardTests
    {
        [Test]
        public void GivenCreditTypeSelected_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            string cardType = "MoneyBack";
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

            Assert.IsNotNull(cardDetails);
            Assert.IsNotEmpty(cardDetails.GetCardType());
            Assert.GreaterOrEqual(cardDetails.GetCreditLimit(), 0);
            Assert.GreaterOrEqual(cardDetails.GetAnnualCharge(), 0);
        }
    }
}