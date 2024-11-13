using Dapper;
using Estate_Dapper_Project.Context;
using Estate_Dapper_Project.Dtos.ImagePropertyDtos;

namespace Estate_Dapper_Project.Services.ImagePropertyServices
{
    public class ImagePropertyService : IImagePropertyService
    { 
        private readonly DapperContext _dapperContext;

        public ImagePropertyService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<List<ResultImageWithProperty>> GetAllImageWithProperty(int id)
        {
            string query = "Select * From ImageProperty where PropertyID=@propertyid";
            var parematers = new DynamicParameters();
            parematers.Add("@propertyid", id); 
            using(var connetion=_dapperContext.CreateConnection())  
            {  
              var values=await connetion.QueryAsync<ResultImageWithProperty>(query,parematers); 
                return values.ToList();
            }
           
        }
    }
}
