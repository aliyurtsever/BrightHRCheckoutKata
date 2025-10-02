using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRCheckoutKata
{
    public class Checkout : ICheckout
    {
        private int _totalPrice = 0;
        public int GetTotalPrice()
        {
            return _totalPrice;
        }

        public void Scan(string item)
        {
            if (item == "A")
            {
                _totalPrice += 50;
            }

            if (item == "B")
            {
                _totalPrice += 30;
            }
        }
    }
}
