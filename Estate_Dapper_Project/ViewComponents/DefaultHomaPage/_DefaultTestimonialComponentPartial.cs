using Estate_Dapper_Project.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.DefaultHomaPage
{
	public class _DefaultTestimonialComponentPartial:ViewComponent
	{  
		private readonly ITestimonialService _testimonialService;

		public _DefaultTestimonialComponentPartial(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{ 
			var values=await _testimonialService.GetAllTestimonialAsync();
			return View(values);
		}
	}
}
