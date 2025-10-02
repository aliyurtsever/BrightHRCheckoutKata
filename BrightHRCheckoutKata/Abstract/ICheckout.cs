
namespace BrightHRCheckoutKata.Abstract
{
    public interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
