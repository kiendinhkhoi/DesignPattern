using Strategy.Models;

namespace Strategy
{
    internal class QuarterDiscount : IDiscountStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.25;
        }
    }
}