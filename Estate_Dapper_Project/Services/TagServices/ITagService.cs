using Estate_Dapper_Project.Dtos.TagDtos;

namespace Estate_Dapper_Project.Services.TagServices
{
    public interface ITagService
    {
        Task<List<ResultTagDto>> GetAllTagWithProduct(int id); 
    }
}
