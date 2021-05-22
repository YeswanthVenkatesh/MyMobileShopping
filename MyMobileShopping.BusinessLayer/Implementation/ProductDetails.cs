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
                    MobilePrice= 780000M
                },

                new Product
                {
                    MobileName="Iphone 11 Pro",
                    MobilePrice= 980000M
                },
                new Product
                {
                    MobileName="Iphone 12",
                    MobilePrice= 850000M
                },

                new Product
                {
                    MobileName="Iphone 12 Pro",
                    MobilePrice= 120000M
                },
                new Product
                {
                    MobileName="Samsung s21",
                    MobilePrice= 750000M
                },

                new Product
                {
                    MobileName="Oppo F20",
                    MobilePrice= 350000M
                },
                new Product
                {
                    MobileName="OnePlus 8",
                    MobilePrice= 450000M
                },

                new Product
                {
                    MobileName="OnePlus 9",
                    MobilePrice= 580000M
                },
            };
            return products;
        }
    }
}
