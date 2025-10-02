using BrightHRCheckoutKata.Abstract;


namespace BrightHRCheckoutKata.Concrete
{
    public class SpecialPriceRule : IPricingRule
    {
        private readonly string _sku;
        private readonly int _unitPrice;
        private readonly int _offerQuantity;
        private readonly int _offerPrice;

        public SpecialPriceRule(string sku, int unitPrice, int offerQuantity, int offerPrice)
        {
            _sku = sku;
            _unitPrice = unitPrice;
            _offerQuantity = offerQuantity;
            _offerPrice = offerPrice;
        }

        public int CalculatePrice(int quantity)
        {
            int offerCount = quantity / _offerQuantity;
            int remainder = quantity % _offerQuantity;
            return offerCount * _offerPrice + remainder * _unitPrice;
        }

        public bool AppliesTo(string sku) => sku == _sku;
    }
}
