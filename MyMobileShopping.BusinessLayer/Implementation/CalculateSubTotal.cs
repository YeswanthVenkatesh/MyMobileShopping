using MyMobileShopping.BusinessLayer.Interfaces;
using System.Collections.Generic;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateSubTotal : ICalculateSubTotal
    {
        public decimal GetSubTotal(List<Product> products)
        {
            decimal subTotal = 0;

            foreach(Product product in products)
            {
                subTotal = subTotal + product.MobilePrice;
            }
            return subTotal;
        }
    }
}
