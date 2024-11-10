using Estate_Dapper_Project.Dtos.TestimonialDtos;

namespace Estate_Dapper_Project.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task CreateTestimonialAsync(CreateTestimonialDto TestimonialDto);
        Task DeleteTestimonialAsync(int id);
        Task<GetByIdTestimonialDto> GetByIdTestimonialAsync(int id);
        Task UpdateTestimonial(UpdateTestimonialDto TestimonialDto);
    }
}
