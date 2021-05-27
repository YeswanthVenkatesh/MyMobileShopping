using MyMobileShopping.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

namespace MyMobileShopping.Controllers
{
    public class PaymentController : Controller
    {
       
        [HttpGet]
        public ActionResult Index(string grandTotal)
        {       
            ViewBag.GrandTotal = grandTotal;
            return View("Payment");
        }

        [HttpPost]
        public ActionResult Pay(CreditCardDetailsModel creditCardDetailsModel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44392/api/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var myContent = JsonConvert.SerializeObject(creditCardDetailsModel);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = client.PostAsync("Values/ValidateCreditCardDetails", byteContent).Result;
                if (result.IsSuccessStatusCode)
                {
                    return Json("Payment Successful");
                }
                else
                {
                    
                    return Json("Payment Failed");
                }
            }
        }
    }
}