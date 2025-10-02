
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
    }
}
