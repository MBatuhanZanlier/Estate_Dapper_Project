namespace Estate_Dapper_Project.Services.StatisticServices
{
	public interface IStatisticService
	{
		int SaleCount(); 
		int RentCount();	 
		int CategoryCount(); 
		string MaxCategoryNameCount();
	}
}
