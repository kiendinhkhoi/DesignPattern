using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    class Ticket
    {
        public double Price { get; set; }
        public IDiscountStrategy DiscountStrategy { get; set; }

        public Ticket()
        {

        }

        public Ticket(IDiscountStrategy discountStrategy)
        {
            DiscountStrategy = discountStrategy;
        }

        public double DoDiscount()
        {
            return DiscountStrategy.DoDiscount(Price);
        }
    }
}
