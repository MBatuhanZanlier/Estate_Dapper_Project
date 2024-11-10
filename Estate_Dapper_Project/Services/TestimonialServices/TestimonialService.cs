using Dapper;
using Estate_Dapper_Project.Context;
using Estate_Dapper_Project.Dtos.CategoryDtos;
using Estate_Dapper_Project.Dtos.TestimonialDtos;

namespace Estate_Dapper_Project.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    { 
        private readonly DapperContext _dapperContext;

        public TestimonialService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateTestimonialAsync(CreateTestimonialDto TestimonialDto)
        {
            string query = "insert into Testimonial (ImageUrl,Subtitle,NameSurname,Degree) values (@imageurl,@subtitle,@namesurname,@degree)";
            var parameters = new DynamicParameters();
            parameters.Add("@imageurl", TestimonialDto.ImageUrl);
            parameters.Add("@subtitle", TestimonialDto.Subtitle);
            parameters.Add("@namesurname", TestimonialDto.NameSurname);
            parameters.Add("@degree", TestimonialDto.Degree);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteTestimonialAsync(int id)
        {
            string query = "Delete From Testimonial Where TestimonialID=@testimonialıd";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialıd", id);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "Select * From Testimonial";
            using (var connection = _dapperContext.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();

            }
        }

        public async Task<GetByIdTestimonialDto> GetByIdTestimonialAsync(int id)
        {
            string query = "Select * From Testimonial Where TestimonialID=@testimonialıd";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialıd", id);
            using (var connection = _dapperContext.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdTestimonialDto>(query, parameters);
                return values;
            }
        }

        public async Task UpdateTestimonial(UpdateTestimonialDto TestimonialDto)
        {
            string query = "Update Testimonial Set ImageUrl=@imageurl,Subtitle=@subtitle,NameSurname=@namesurname,Degree=@degree where TestimonialID=@testimonialıd";
            var parameters = new DynamicParameters();
            parameters.Add("@imageurl", TestimonialDto.ImageUrl);
            parameters.Add("@subtitle", TestimonialDto.Subtitle);
            parameters.Add("@namesurname", TestimonialDto.NameSurname);
            parameters.Add("@degree", TestimonialDto.Degree);
            parameters.Add("@testimonialıd", TestimonialDto.TestimonialID);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
