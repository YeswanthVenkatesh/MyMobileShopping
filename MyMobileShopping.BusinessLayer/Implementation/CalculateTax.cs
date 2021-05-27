using MyMobileShopping.BusinessLayer.Interfaces;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateTax : ICalculateTax
    {
        public decimal GetTax(decimal subTotal)
        {
            return subTotal * 18 / 100;
        }
    }
}
