using Estate_Dapper_Project.Dtos.ImagePropertyDtos;

namespace Estate_Dapper_Project.Services.ImagePropertyServices
{
    public interface IImagePropertyService
    {
        Task<List<ResultImageWithProperty>> GetAllImageWithProperty(int id);
    }
}
