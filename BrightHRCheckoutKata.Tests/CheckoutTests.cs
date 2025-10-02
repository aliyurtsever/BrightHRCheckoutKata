
namespace BrightHRCheckoutKata.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void CanCreateAnInstanceOfCheckout()
        {
            var checkout = new Checkout();

            Assert.That(checkout, Does.Not.Null);
        }

        [Test]
        public void GetTotalPrice_NoItemsScanned_ReturnsZero()
        {
            var checkout = new Checkout();

            var total =  checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(0));
        }
    }
}
