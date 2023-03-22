namespace TaxiManager.Services.Data.Interfaces
{
    using TaxiManager.Web.ViewModels.Orders;

    public interface IOrdersService
    {
        void New(OrderAddViewModel input);

        void Accept(string id);

        void Decline(string id);

        void Delete(string id);
    }
}
