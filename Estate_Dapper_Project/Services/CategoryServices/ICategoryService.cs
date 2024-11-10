using Estate_Dapper_Project.Dtos.CategoryDtos;

namespace Estate_Dapper_Project.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto categoryDto); 
        Task DeleteCategoryAsync(int id); 
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id); 
        Task UpdateCategory(UpdateCategoryDto categoryDto);
    }
}
