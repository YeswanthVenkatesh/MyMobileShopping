using System;

namespace MyMobileShopping.Models
{
    public class CreditCardDetailsModel
    {
            public string CardNumber { get; set; }
            public string CVVNumber { get; set; }
            public DateTime ExpiryDate { get; set; }
        
    }
}