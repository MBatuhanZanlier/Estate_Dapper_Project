using Estate_Dapper_Project.Dtos.ServiceDtos;

namespace Estate_Dapper_Project.Services.ServiceServices
{
    public interface IServiceService
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        Task CreateServiceAsync(CreateServiceDto ServiceDto);
        Task DeleteServiceAsync(int id);
        Task<GetByIdServiceDto> GetByIdServiceAsync(int id);
        Task UpdateService(UpdateServiceDto ServiceDto);
    }
}
