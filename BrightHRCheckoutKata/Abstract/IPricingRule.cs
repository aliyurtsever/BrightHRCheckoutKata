
namespace BrightHRCheckoutKata.Abstract
{
    public interface IPricingRule
    {
        bool AppliesTo(string sku);
        int CalculatePrice(int quantity);
    }
}
