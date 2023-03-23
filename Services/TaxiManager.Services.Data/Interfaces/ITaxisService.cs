namespace TaxiManager.Services.Data.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using TaxiManager.Web.ViewModels.Taxis;

    public interface ITaxisService
    {
        Task AddAsync(TaxiAddInputModel input, string imagePath);

        public List<AvailableOrdersViewModel> GetAllAvailable(string userId);
    }
}
