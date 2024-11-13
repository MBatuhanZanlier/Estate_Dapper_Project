using Dapper;
using Estate_Dapper_Project.Context;

namespace Estate_Dapper_Project.Services.StatisticServices
{
	public class StatisticService : IStatisticService
	{ 
		private readonly DapperContext _context;

		public StatisticService(DapperContext context)
		{
			_context = context;
		}

		public int CategoryCount()
		{
			string query = "Select Count(*) From Category";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;

			}
		}

		public string MaxCategoryNameCount()
		{
			string query = "SELECT TOP 1 CategoryName, COUNT(*) AS ProductCount FROM Property INNER JOIN Category ON Property.PropertyCategoryID = Category.CategoryID GROUP BY CategoryName ORDER BY ProductCount DESC;";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<string>(query);
				return values;

			}
		}

		public int RentCount()
		{
			string query = "Select Count(*) From Property inner join Location on Property.PropertyLocationID=Location.LocationID where Type='Kiralık' ";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;

			}
		}

		public int SaleCount()
		{
			string query = "Select Count(*) From Property inner join Location on Property.PropertyLocationID=Location.LocationID where Type='Satılık' ";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;

			}
		}
	}
}
