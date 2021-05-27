namespace MyMobileShopping.BusinessLayer.Interfaces
{
    public interface ICalculateTax
    {
        decimal GetTax(decimal subTotal);
    }
}
