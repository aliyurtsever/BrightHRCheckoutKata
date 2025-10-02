
namespace BrightHRCheckoutKata.Concrete
{
    public class Basket
    {
        private readonly Dictionary<string, int> _items = new();

        public void Add(string sku)
        {
            if (!_items.ContainsKey(sku))
                _items[sku] = 0;
            _items[sku]++;
        }

        public IReadOnlyDictionary<string, int> Items => _items;
    }
}
