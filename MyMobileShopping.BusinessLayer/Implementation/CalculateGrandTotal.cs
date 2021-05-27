using MyMobileShopping.BusinessLayer.Interfaces;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateGrandTotal : ICalculateGrandTotal
    {
        public decimal GetGrandTotal(decimal subTotal, decimal tax, decimal discount)
        {
            return subTotal + tax - discount;
        }
    }
}
