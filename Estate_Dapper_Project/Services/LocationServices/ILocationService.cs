using Estate_Dapper_Project.Dtos.LocationDtos;

namespace Estate_Dapper_Project.Services.LocationServices
{
    public interface ILocationService
    {
        Task<List<ResultLocationDto>> GetAllLocationAsync();
        Task CreateLocationAsync(CreateLocationDto LocationDto);
        Task DeleteLocationAsync(int id);
        Task<GetByIdLocationDto> GetByIdLocationAsync(int id);
        Task UpdateLocation(UpdateLocationDto LocationDto);
    }
}
