using Estate_Dapper_Project.Services.PropertyServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.DefaultHomaPage
{
	public class _DefaultSliderComponentPartial:ViewComponent
	{
		private readonly IPropertyService _propertyService;

		public _DefaultSliderComponentPartial(IPropertyService propertyService)
		{
			_propertyService = propertyService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _propertyService.GetAllPropertySliderAsync(); 
			return View(values);
		}
	}
}
