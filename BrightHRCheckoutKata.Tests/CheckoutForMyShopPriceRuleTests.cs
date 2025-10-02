using BrightHRCheckoutKata.Abstract;
using BrightHRCheckoutKata.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRCheckoutKata.Tests
{
    [TestFixture]
    public class CheckoutForMyShopPriceRuleTests
    {
        [Test]
        public void GetTotalPrice_ScannedForMyShopPriceRule_Returns50()
        {
            var customPricingRule = new List<IPricingRule>{
                                    new UnitPriceRule("A", 50),
                                    new SpecialPriceRule("B", 30,3,60),
                                    new MyShopPriceRule("C",20,4,60,5),
                            };

            var checkout = new Checkout(customPricingRule);

            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(100));
        }

        [Test]
        public void GetTotalPrice_ScannedSingleBItem_Returns30()
        {
            var customPricingRule = new List<IPricingRule>{
                                    new UnitPriceRule("A", 50),
                                    new SpecialPriceRule("B", 30,3,60),
                                    new MyShopPriceRule("C",20,4,60,5),
                            };

            var checkout = new Checkout(customPricingRule);

            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            var total = checkout.GetTotalPrice();

            Assert.That(total, Is.EqualTo(137));
        }
    }
}
