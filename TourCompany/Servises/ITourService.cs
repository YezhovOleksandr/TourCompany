using Models.Models;
using Models.ViewModel;

namespace TourCompany.Servises
{
    public interface ITourService
    {
        Task<IEnumerable<Tour>> GetAllToursAsync();
        Task AddTourAsync(TourAddViewModel tour);
        Task<Tour> GetTourByIdAsync(int? tourId);
        Task UpdateTourAsync(Tour tour);
        Task DeleteTourByIdAsync(int id);
    }
}
