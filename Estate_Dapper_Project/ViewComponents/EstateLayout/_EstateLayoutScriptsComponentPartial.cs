using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.EstateLayout
{
	public class _EstateLayoutScriptsComponentPartial:ViewComponent
	{ 
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
