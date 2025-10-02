using BrightHRCheckoutKata.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRCheckoutKata.Concrete
{
    public class MyShopPriceRule : IPricingRule
    {
        private readonly string _sku;
        private readonly int _unitPrice;
        private readonly int _offerQuantity;
        private readonly int _offerPrice;
        private readonly int _additionalDiscount;

        public MyShopPriceRule(string sku, int unitPrice, int offerQuantity, int offerPrice, int additionalDiscount)
        {
            _sku = sku;
            _unitPrice = unitPrice;
            _offerQuantity = offerQuantity;
            _offerPrice = offerPrice;
            _additionalDiscount = additionalDiscount;//give additional X percent discount if offer quantity matches
        }

        public int CalculatePrice(int quantity)
        {
            int offerCount = quantity / _offerQuantity;
            int remainder = quantity % _offerQuantity;
            int total = offerCount * _offerPrice + remainder * _unitPrice;

            if(offerCount > 0)
            {
                decimal discount = total * (_additionalDiscount / 100m);
                total -= (int)discount;// we normally use decimal for prices but in this case it is int so I convert it to int.
            }
           
            return total;
        }

        public bool AppliesTo(string sku) => sku == _sku;
    }
}
