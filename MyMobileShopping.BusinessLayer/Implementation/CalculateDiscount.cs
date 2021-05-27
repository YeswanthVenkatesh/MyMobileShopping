using MyMobileShopping.BusinessLayer.Interfaces;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateDiscount : ICalculateDiscount
    {
        public decimal GetDiscount(decimal subTotal)
        {
            if (subTotal < 80000)
                return subTotal * 5 / 100;
            else if (subTotal >= 80000 && subTotal <= 120000)
                return subTotal * 15 / 100;
            else if (subTotal > 120000)
                return subTotal * 25 / 100;
            else 
                return 0;
        }
    }
}
