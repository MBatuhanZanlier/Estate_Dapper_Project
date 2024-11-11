using Dapper;
using Estate_Dapper_Project.Context;
using Estate_Dapper_Project.Dtos.CategoryDtos;
using Estate_Dapper_Project.Dtos.PropertDtos;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Estate_Dapper_Project.Services.PropertyServices
{
    public class PropertyService:IPropertyService
    {
        private readonly DapperContext _context;

        public PropertyService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreatePropertyAsync(CreatePropertyDto PropertyDto)
        {
            string query = "INSERT INTO Property (ProductTitle, Subtitle, Description, BedCount, BathRoom, Garage, BuildYear,VideoEmbend, CoverImage, Price, Address, Type, IsFeatured, PropertyLocationID, PropertyCategoryID) values (@ProductTitle, @Subtitle, @Description, @BedCount, @BathRoom, @Garage, @BuildYear,@VideoEmbend, @CoverImage, @Price, @Address, @Type, @IsFeatured, @PropertyLocationID, @PropertyCategoryID);";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductTitle", PropertyDto.ProductTitle);
            parameters.Add("@Subtitle", PropertyDto.Subtitle);
            parameters.Add("@Description", PropertyDto.Description);
            parameters.Add("@BedCount", PropertyDto.BedCount);
            parameters.Add("@BathRoom", PropertyDto.BathRoom);
            parameters.Add("@Garage", PropertyDto.Garage);
            parameters.Add("@BuildYear", PropertyDto.BuildYear);
            parameters.Add("@VideoEmbend", PropertyDto.VideoEmbend);
            parameters.Add("@CoverImage", PropertyDto.CoverImage);
            parameters.Add("@Price", PropertyDto.Price);
            parameters.Add("@Address", PropertyDto.Address);
            parameters.Add("@Type", PropertyDto.Type);
            parameters.Add("@IsFeatured", true);
            parameters.Add("@PropertyLocationID", PropertyDto.PropertyLocationID);
            parameters.Add("@PropertyCategoryID", PropertyDto.PropertyCategoryID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }

        public  async Task DeletePropertyAsync(int id)
        {
            string query = "Delete From Property Where PropertyID=@propertyıd";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyıd", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }

        public async Task<List<ResultPropertyDto>> GetAllPropertyAsync()
        {
            string query = "Select ProductTitle,Subtitle,Description,BedCount,BathRoom,Garage,BuildYear,VideoEmbend,CoverImage,Price,Address,Type,IsFeatured,CategoryName,locationName FROM Property INNER JOIN Category on Property.PropertyCategoryID=Category.CategoryID INNER JOIN Location on Property.PropertyLocationID=Location.LocationID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyDto>(query);
                return values.ToList();

            }
        }

		public async Task<List<ResultSliderDto>> GetAllPropertySliderAsync()
		{
			string query = "Select PropertyID,ProductTitle,Subtitle,CoverImage,Price,Address,LocationName From Property Inner Join Location on Property.PropertyLocationID=Location.LocationID  where IsFeatured=1";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultSliderDto>(query);
				return values.ToList();

			}
		}

        public async Task<List<ResultPropertyFeatureDto>> GetAlltPropertyFeatures()
        {
            string query = "SELECT TOP 5  PropertyID, CoverImage, Type,ProductTitle,Subtitle,Price,CategoryName FROM Property INNER JOIN Category ON Property.PropertyCategoryID = Category.CategoryID WHERE IsFeatured = 1 ORDER BY PropertyID DESC";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyFeatureDto>(query);
                return values.ToList();

            }
        }

        public async Task<GetByIdPropertyDto> GetByIdPropertyAsync(int id)
        {
            string query = "Select ProductTitle,Subtitle,Description,BedCount,BathRoom,Garage,BuildYear,VideoEmbend,CoverImage,Price,Address,Type,IsFeatured,CategoryName,locationName FROM Property INNER JOIN Category on Property.PropertyCategoryID=Category.CategoryID INNER JOIN Location on Property.PropertyLocationID=Location.LocationID Where PropertyID=@propertyıd";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyıd", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdPropertyDto>(query,parameters);
                return values;


            }
        }

		public async Task<List<ResultLast5Property>> GetLast5PropertyFeatures()
		{
			string query = "SELECT TOP 10  PropertyID, CoverImage, Type,ProductTitle,Subtitle,Price,CategoryName FROM Property INNER JOIN Category ON Property.PropertyCategoryID = Category.CategoryID  ORDER BY PropertyID DESC";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultLast5Property>(query);
				return values.ToList();

			}
		}

		public async Task UpdateProperty(UpdatePropertyDto property)
        {
            string query = @"
                UPDATE Property
                SET 
                    ProductTitle = @ProductTitle,
                    Subtitle = @Subtitle,
                    Description = @Description,
                    BedCount = @BedCount,
                    BathRoom = @BathRoom,
                    Garage = @Garage,
                    BuildYear = @BuildYear,
                    VideoEmbend = @VideoEmbend,
                    CoverImage = @CoverImage,
                    Price = @Price,
                    Address = @Address,
                    Type = @Type,
                    IsFeatured = @IsFeatured,
                    PropertyLocationID = @PropertyLocationID,
                    PropertyCategoryID = @PropertyCategoryID
                WHERE PropertyID = @PropertyID;";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductTitle", property.ProductTitle);
            parameters.Add("@Subtitle", property.Subtitle);
            parameters.Add("@Description", property.Description);
            parameters.Add("@BedCount", property.BedCount);
            parameters.Add("@BathRoom", property.BathRoom);
            parameters.Add("@Garage", property.Garage);
            parameters.Add("@BuildYear", property.BuildYear);
            parameters.Add("@VideoEmbend", property.VideoEmbend);
            parameters.Add("@CoverImage", property.CoverImage);
            parameters.Add("@Price", property.Price);
            parameters.Add("@Address", property.Address);
            parameters.Add("@Type", property.Type);
            parameters.Add("@IsFeatured", true);
            parameters.Add("@PropertyLocationID", property.PropertyLocationID);
            parameters.Add("@PropertyCategoryID", property.PropertyCategoryID);
            parameters.Add("@PropertyID", property.PropertyID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }
    }
}
