using Estate_Dapper_Project.Services.StatisticServices;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Estate_Dapper_Project.ViewComponents.DefaultHomaPage
{
    public class _DefaulStatisticComponentPartial : ViewComponent
    {     
        private readonly IStatisticService _statisticService;

		public _DefaulStatisticComponentPartial(IStatisticService statisticService)
		{
			_statisticService = statisticService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.rentcount = _statisticService.RentCount(); 
            ViewBag.salecount = _statisticService.SaleCount(); 
            ViewBag.categorycount = _statisticService.CategoryCount(); 
            ViewBag.maxcategorynamecount = _statisticService.MaxCategoryNameCount(); 

            return View();
        }

    }
}
