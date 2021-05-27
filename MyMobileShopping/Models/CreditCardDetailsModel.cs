using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMobileShopping.Models
{
    public class CreditCardDetailsModel
    {
            public string CardNumber { get; set; }
            public string CVVNumber { get; set; }
            public DateTime ExpiryDate { get; set; }
        
    }
}