using System.Collections.Generic;

namespace MyMobileShopping.BusinessLayer.Interfaces
{
    public interface ICalculateCartFlow
    {
        CartModel Calculate(List<Product> products);
    }
}
