using Estate_Dapper_Project.Context;
using Estate_Dapper_Project.Dtos.PropertDtos;
using X.PagedList;


namespace Estate_Dapper_Project.Services.PropertyServices
{
    public interface IPropertyService
    {
        Task<List<ResultPropertyDto>> GetAllPropertyAsync();
        Task CreatePropertyAsync(CreatePropertyDto PropertyDto);
        Task DeletePropertyAsync(int id);
        Task<GetByIdPropertyDto> GetByIdPropertyAsync(int id);
        Task UpdateProperty(UpdatePropertyDto PropertyDto);
        Task<List<ResultSliderDto>> GetAllPropertySliderAsync();
        Task<List<ResultPropertyFeatureDto>> GetAlltPropertyFeatures();
        Task<List<ResultLast5Property>> GetLast5PropertyFeatures();
        Task<IPagedList<ResultPagedWithProperty>> GetAllPagedListProperty(int pageNumber, int pageSize);
        Task<List<ResultLast2Propery>> GetAllLast2Property();
        Task<List<ResultCategoryCount>> GetPropertyWithCategoryCount();
		Task<List<ResultProducthSearchListDto>> ResultProductWithSearchList( int propertyCategoryıd, string Type);
	}
}
