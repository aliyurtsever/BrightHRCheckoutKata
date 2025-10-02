using BrightHRCheckoutKata.Abstract;

namespace BrightHRCheckoutKata.Concrete
{
    public class Checkout : ICheckout
    {
        private readonly Basket _basket = new();
        private readonly List<IPricingRule> _pricingRules;

        public Checkout() : this(DefaultPriceRule.GetDefaultPricingRules())
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
                var rule = _pricingRules.FirstOrDefault(r => r.AppliesTo(item.Key));

                if (rule != null)
                {
                    total += rule.CalculatePrice(item.Value);
                }
            }

            return total;
        }

        public void Scan(string item)
        {
            if (_pricingRules.Any(r => r.AppliesTo(item)))
            {
                _basket.Add(item);
            }               
        }
    }
}
