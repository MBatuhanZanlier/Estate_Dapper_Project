using Dapper;
using Estate_Dapper_Project.Context;
using Estate_Dapper_Project.Dtos.CategoryDtos;
using Estate_Dapper_Project.Dtos.LocationDtos;

namespace Estate_Dapper_Project.Services.LocationServices
{
    public class LocationService : ILocationService
    {
        private readonly DapperContext _dapperContext;

        public LocationService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateLocationAsync(CreateLocationDto LocationDto)
        {
            string query = "insert into Location (LocationName) values (@locationname)";
            var parameters = new DynamicParameters();
            parameters.Add("@locationname", LocationDto.LocationName);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteLocationAsync(int id)
        {
            string query = "Delete From Location Where LocationID=@locationıd";
            var parameters = new DynamicParameters();
            parameters.Add("@@locationıd", id);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }

        public async Task<List<ResultLocationDto>> GetAllLocationAsync()
        {
            string query = "Select * From Location";
            using (var connection = _dapperContext.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLocationDto>(query);
                return values.ToList();

            }
        }

        public async Task<GetByIdLocationDto> GetByIdLocationAsync(int id)
        {
            string query = "Select * From Location where LocationID=@locationıd";
            using (var connection = _dapperContext.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdLocationDto>(query);
                return values;

            }
        }

        public async Task UpdateLocation(UpdateLocationDto LocationDto)
        {
            string query = "Update Location Set LocationName=@locationname where LocationID=@locationıd";
            var paremets = new DynamicParameters();
            paremets.Add("@locationname", LocationDto.LocationName);
            paremets.Add("@locationıd", LocationDto.LocationID);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query,paremets);

            }
        }
    }
}
