using Models.Models;
using TourCompany.Repositories;

namespace TourCompany.Servises.impl
{
    public class TourService : ITourService
    {
        private readonly IGenericRepository<Tour> _tourRepository;

        public TourService(IGenericRepository<Tour> tourRepository)
        {
            _tourRepository = tourRepository;
        }
        public async Task AddTourAsync(Tour tour)
        {
            await _tourRepository.AddAsync(tour);
        }

        public async Task DeleteTourByIdAsync(int id)
        {
            await _tourRepository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<Tour>> GetAllToursAsync()
        {
            IEnumerable<Tour> tours = await _tourRepository.GetAllAsync();
            return tours;
        }

        public async Task<Tour> GetTourByIdAsync(int? tourId)
        {
            Tour tour = await _tourRepository.GetByIdAsync(tourId);
            return tour;
        }

        public async Task UpdateTourAsync(Tour tour)
        {
            Tour updateTour = await _tourRepository.GetByIdAsync(tour.TourId);
            updateTour.TourName = tour.TourName;
            updateTour.TourShortDescription = tour.TourShortDescription;
            updateTour.TourDescription = tour.TourDescription;
            updateTour.TourPrice = tour.TourPrice;

            await _tourRepository.UpdateAsync(updateTour);
        }
    }
}
