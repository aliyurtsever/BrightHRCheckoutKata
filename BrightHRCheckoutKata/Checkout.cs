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
        private int _countA = 0;
        public int GetTotalPrice()
        {
            int trippleScanned = _countA / 3;
            int remainingScanned = _countA % 3;
            _totalPrice += trippleScanned * 130 + remainingScanned * 50;

            return _totalPrice;
        }

        public void Scan(string item)
        {
            if (item == "A")
            {
                _countA++;
            }

            if (item == "B")
            {
                _totalPrice += 30;
            }

            if (item == "C")
            {
                _totalPrice += 20;
            }

            if (item == "D")
            {
                _totalPrice += 15;
            }
        }
    }
}
