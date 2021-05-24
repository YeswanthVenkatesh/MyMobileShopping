using MyMobileShopping.BusinessLayer;
using System.Collections.Generic;

namespace MyMobileShopping.Models
{
    public class CartViewModel
    {
        public List<Product> Products { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Discount { get; set; }

        public decimal GrandTotal { get; set; }
    }
}