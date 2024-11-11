using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.EstateLayout
{
	public class _EstateLayoutFooterComponentPartial:ViewComponent
	{ 
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
