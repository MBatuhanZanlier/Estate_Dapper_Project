using Estate_Dapper_Project.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Estate_Dapper_Project.ViewComponents.DefaultHomaPage
{
	public class _DefaultServiceComponentPartial:ViewComponent
	{  
		private readonly IServiceService _serviceService;

		public _DefaultServiceComponentPartial(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			 var values=await _serviceService.GetAllServiceAsync(); 
			return View(values);
		}
	}
}
