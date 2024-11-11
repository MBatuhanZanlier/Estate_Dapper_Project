using Estate_Dapper_Project.Services.PropertyServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.DefaultHomaPage
{
	public class _DefaultLast5PropertyComponentPartial:ViewComponent
	{  
		private readonly IPropertyService _propertyService;

		public _DefaultLast5PropertyComponentPartial(IPropertyService propertyService)
		{
			_propertyService = propertyService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _propertyService.GetLast5PropertyFeatures();
			return View(values);
		}
	}
}
