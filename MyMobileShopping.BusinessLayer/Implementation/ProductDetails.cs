using MyMobileShopping.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class ProductDetails : IProductDetails
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    MobileName="Iphone 11",
                    MobilePrice= 78000M
                },

                new Product
                {
                    MobileName="Iphone 11 Pro",
                    MobilePrice= 98000M
                },
                new Product
                {
                    MobileName="Iphone 12",
                    MobilePrice= 85000M
                },

                new Product
                {
                    MobileName="Iphone 12 Pro",
                    MobilePrice= 120000M
                },
                new Product
                {
                    MobileName="Samsung s21",
                    MobilePrice= 75000M
                },

                new Product
                {
                    MobileName="Oppo F20",
                    MobilePrice= 35000M
                },
                new Product
                {
                    MobileName="OnePlus 8",
                    MobilePrice= 45000M
                },

                new Product
                {
                    MobileName="OnePlus 9",
                    MobilePrice= 58000M
                },
            };
            return products;
        }
    }
}
