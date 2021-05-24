using MyMobileShopping.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
