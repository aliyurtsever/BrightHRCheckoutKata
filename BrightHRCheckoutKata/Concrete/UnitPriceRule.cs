using BrightHRCheckoutKata.Abstract;

namespace BrightHRCheckoutKata.Concrete
{
    public class UnitPriceRule : IPricingRule
    {
        public string Sku { get; }
        private readonly int _unitPrice;

        public UnitPriceRule(string sku, int unitPrice)
        {
            Sku = sku;
            _unitPrice = unitPrice;
        }

        public int CalculatePrice(int quantity) => quantity * _unitPrice;
    }
}
