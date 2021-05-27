namespace MyMobileShopping.BusinessLayer.Interfaces
{
    public interface ICalculateGrandTotal
    {
        decimal GetGrandTotal(decimal subTotal, decimal tax, decimal discount);
    }
}
