using System.Collections.Generic;

namespace MyMobileShopping.BusinessLayer
{
    public class CartModel
    {
        public List<Product> Products { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Discount { get; set; }

        public decimal GrandTotal { get; set; } 
    }
}
