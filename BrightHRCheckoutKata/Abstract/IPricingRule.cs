
namespace BrightHRCheckoutKata.Abstract
{
    public interface IPricingRule
    {
        string Sku { get; }
        int CalculatePrice(int quantity);
    }
}
