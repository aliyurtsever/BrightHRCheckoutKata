
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

        [Test]
        public void GetTotalPrice_ScannedSingleAItem_Returns50()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(50));
        }

        [Test]
        public void GetTotalPrice_ScannedSingleBItem_Returns30()
        {
            var checkout = new Checkout();

            checkout.Scan("B");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(30));
        }

        [Test]
        public void GetTotalPrice_ScannedSingleCItem_Returns20()
        {
            var checkout = new Checkout();

            checkout.Scan("C");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(20));
        }

        [Test]
        public void GetTotalPrice_ScannedSingleDItem_Returns15()
        {
            var checkout = new Checkout();

            checkout.Scan("D");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(15));
        }

        [Test]
        public void GetTotalPrice_ScannedAllItems_Returns115()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("D");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(115));
        }

        [Test]
        public void GetTotalPrice_ScannedWithoutSpecialPriceItems_Returns200()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("D");
            checkout.Scan("D");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(200));
        }

        [Test]
        public void GetTotalPrice_Scanned3AItems_Returns130()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(130));
        }


        [Test]
        public void GetTotalPrice_Scanned4AItems_Returns180()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(180));
        }
    }
}
