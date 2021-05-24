using MyMobileShopping.BusinessLayer.Interfaces;
using System.Collections.Generic;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateCartFlow : ICalculateCartFlow
    {
        private readonly ICalculateSubTotal calculateSubTotal;
        private readonly ICalculateTax calculateTax;
        private readonly ICalculateDiscount calculateDiscount;
        private readonly ICalculateGrandTotal calculateGrandTotal;

        public CalculateCartFlow(CalculateSubTotal calculateSubTotal, 
            CalculateTax calculateTax, CalculateDiscount calculateDiscount,
            CalculateGrandTotal calculateGrandTotal)
        {
            this.calculateSubTotal = calculateSubTotal;
            this.calculateTax = calculateTax;
            this.calculateDiscount = calculateDiscount;
            this.calculateGrandTotal = calculateGrandTotal;
        }
        public CartModel Calculate(List<Product> products)
        {
            CartModel cartModel = new CartModel();
            cartModel.SubTotal = calculateSubTotal.GetSubTotal(products);
            cartModel.Tax = calculateTax.GetTax(cartModel.SubTotal);
            cartModel.Discount = calculateDiscount.GetDiscount(cartModel.SubTotal);
            cartModel.GrandTotal = calculateGrandTotal.GetGrandTotal(cartModel.SubTotal, cartModel.Tax, cartModel.Discount);
            cartModel.Products = products;
            return cartModel;
        }
    }
}
