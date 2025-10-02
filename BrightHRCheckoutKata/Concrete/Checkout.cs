using BrightHRCheckoutKata.Abstract;

namespace BrightHRCheckoutKata.Concrete
{
    public class Checkout : ICheckout
    {
        private readonly Basket _basket = new();
        private readonly List<IPricingRule> _pricingRules;

        public Checkout() : this(GetDefaultPricingRules())
        {

        }

        public Checkout(IEnumerable<IPricingRule> pricingRules)
        {
            _pricingRules = pricingRules.ToList();
        }

        public int GetTotalPrice()
        {
            int total = 0;
            foreach (var item in _basket.Items)
            {
                var rule = _pricingRules.FirstOrDefault(r => r.Sku == item.Key);

                total += rule.CalculatePrice(item.Value);
            }

            return total;
        }

        public void Scan(string item)
        {
            _basket.Add(item);
        }

        private static IEnumerable<IPricingRule> GetDefaultPricingRules()
        {
            return new List<IPricingRule> {
            new SpecialPriceRule("A", 50, 3, 130),
            new SpecialPriceRule("B", 30, 2, 45),
            new UnitPriceRule("C", 20),
            new UnitPriceRule("D", 15)
            };
        }
    }
}
