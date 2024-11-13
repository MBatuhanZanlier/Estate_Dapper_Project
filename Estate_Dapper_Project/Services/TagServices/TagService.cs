using Dapper;
using Estate_Dapper_Project.Context;
using Estate_Dapper_Project.Dtos.ImagePropertyDtos;
using Estate_Dapper_Project.Dtos.TagDtos;

namespace Estate_Dapper_Project.Services.TagServices
{
    public class TagService : ITagService
    { 
        private readonly DapperContext _dapperContext;

        public TagService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<List<ResultTagDto>> GetAllTagWithProduct(int id)
        {
            string query = "Select * From Tag where TagPropertyID=@propertyid";
            var parematers = new DynamicParameters();
            parematers.Add("@propertyid", id);
            using (var connetion = _dapperContext.CreateConnection())
            {
                var values = await connetion.QueryAsync<ResultTagDto>(query, parematers);
                return values.ToList();
            }

        }
    }
}
