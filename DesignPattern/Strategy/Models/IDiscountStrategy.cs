namespace Strategy.Models
{
    public interface IDiscountStrategy
    {
        double DoDiscount(double price);
    }
}