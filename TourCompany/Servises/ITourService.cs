using Models.Models;

namespace TourCompany.Servises
{
    public interface ITourService
    {
        Task<IEnumerable<Tour>> GetAllToursAsync();
        Task AddTourAsync(Tour tour);
        Task<Tour> GetTourByIdAsync(int? tourId);
        Task UpdateTourAsync(Tour tour);
        Task DeleteTourByIdAsync(int id);
    }
}
