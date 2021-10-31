using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    class NoDiscount : IDiscountStrategy
    {
        public double DoDiscount(double price)
        {
            return price;
        }
    }
}
