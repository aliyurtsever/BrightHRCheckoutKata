using BrightHRCheckoutKata.Abstract;

namespace BrightHRCheckoutKata.Concrete
{
    public class UnitPriceRule : IPricingRule
    {
        private readonly string _sku;
        private readonly int _unitPrice;

        public UnitPriceRule(string sku, int unitPrice)
        {
            _sku = sku;
            _unitPrice = unitPrice;
        }

        public int CalculatePrice(int quantity) => quantity * _unitPrice;

        public bool AppliesTo(string sku) => sku == _sku;
    }
}
