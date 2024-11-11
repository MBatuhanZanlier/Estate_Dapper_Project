using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.DefaultHomaPage
{
	public class _DefaultSearchComponentPartial:ViewComponent
	{ 
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
