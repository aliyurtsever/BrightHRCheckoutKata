using BrightHRCheckoutKata.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRCheckoutKata.Concrete
{
    public static class DefaultPriceRule
    {
        public static IEnumerable<IPricingRule> GetDefaultPricingRules()
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
