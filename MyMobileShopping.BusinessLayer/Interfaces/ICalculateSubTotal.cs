using System.Collections.Generic;

namespace MyMobileShopping.BusinessLayer.Interfaces
{
    public interface ICalculateSubTotal
    {
        decimal GetSubTotal(List<Product> products);
    }
}
