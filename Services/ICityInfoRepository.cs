using CityInfoAPI.Entities;

namespace CityInfoAPI.Services
{
    public interface ICityInfoRepository
    {
        Task<bool> CityExistsAsync(int cityId);

        Task<IEnumerable<City>> GetCitiesAsync();

        Task<(IEnumerable<City>, PaginationMetadata)> GetCitiesAsync(string? name, string? seachQuery, int pageNumber, int pageSize);

        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);

        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsync(int cityId);

        Task<PointOfInterest?> GetPointOfInterestForCityAsync(int cityId, int pointOfInterestId);

        Task AddPointOfInterestForCityAsync(int cityId, PointOfInterest pointOfInterest);

        void DeletePointOfInterest(PointOfInterest pointOfInterest);

        Task<bool> CityMatchesCityId(string? cityName, int cityId);

        Task<bool> SaveChangesAsync();
    }
}
 