using BrightHRCheckoutKata.Abstract;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace BrightHRCheckoutKata.Concrete
{
    public class Checkout : ICheckout
    {
        private readonly Basket _basket = new();
        private readonly List<IPricingRule> _pricingRules;
        private readonly ILogger<Checkout> _logger;

        public Checkout() : this(DefaultPriceRule.GetDefaultPricingRules())
        {

        }

        public Checkout(IEnumerable<IPricingRule> pricingRules, ILogger<Checkout>? logger = null)
        {
            _pricingRules = pricingRules.ToList();
            _logger = logger ?? NullLogger<Checkout>.Instance;
        }

        public int GetTotalPrice()
        {
            int total = 0;

            try
            {
                foreach (var item in _basket.Items)
                {
                    var rule = _pricingRules.FirstOrDefault(r => r.AppliesTo(item.Key));

                    if (rule != null)
                    {
                        total += rule.CalculatePrice(item.Value);
                    }
                    else
                    {
                        _logger.LogInformation("Pricing rule does not exists for {Item}", item.Key);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An exception occurred during getting total price.");
            }

            return total;
        }

        public void Scan(string item)
        {
            try
            {
                if (_pricingRules.Any(r => r.AppliesTo(item)))
                {
                    _basket.Add(item);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An exception occurred during scanning item {Item}.", item);
            }
        }
    }
}
