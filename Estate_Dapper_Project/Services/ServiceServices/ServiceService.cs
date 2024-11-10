using Dapper;
using Estate_Dapper_Project.Context;
using Estate_Dapper_Project.Dtos.CategoryDtos;
using Estate_Dapper_Project.Dtos.ServiceDtos;

namespace Estate_Dapper_Project.Services.ServiceServices
{
    public class ServiceService : IServiceService
    { 
        private readonly DapperContext _dapperContext;

        public ServiceService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateServiceAsync(CreateServiceDto ServiceDto)
        {
            string query = "insert into Service (İcon,Title,Subtitle) values (@ıcon,@title,@subtitle)";
            var parameters = new DynamicParameters();
            parameters.Add("@ıcon", ServiceDto.Icon);
            parameters.Add("@title", ServiceDto.Title);
            parameters.Add("@subtitle", ServiceDto.SubTitle);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteServiceAsync(int id)
        {
            string query = "Delete From Service Where ServiceID=@serviceıd";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceıd", id);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * From Service";
            using (var connection = _dapperContext.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();

            };
        }

        public async Task<GetByIdServiceDto> GetByIdServiceAsync(int id)
        {
            string query = "Select * From Category Where ServiceID=@serviceıd";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceıd", id);
            using (var connection = _dapperContext.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdServiceDto>(query, parameters);
                return values;
            }
        }

        public async Task UpdateService(UpdateServiceDto ServiceDto)
        {
            string query = "Update Service Set İcon=@ıcon,Title=@title,Subtitle=@subtitle  where ServiceID=@serviceıd";
            var parameters = new DynamicParameters();
            parameters.Add("@ıcon", ServiceDto.İcon);
            parameters.Add("@title", ServiceDto.Title);
            parameters.Add("@subtitle", ServiceDto.SubTitle);
            parameters.Add("@serviceıd", ServiceDto.ServiceID);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
