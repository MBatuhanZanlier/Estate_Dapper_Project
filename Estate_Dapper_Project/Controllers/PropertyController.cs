using Estate_Dapper_Project.Services.PropertyServices;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Estate_Dapper_Project.Controllers
{
    public class PropertyController : Controller
	{ 
		private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public async Task<IActionResult> Index(int page=1,int pagesize=6)
		{
			var values = await _propertyService.GetAllPagedListProperty(page,pagesize);
			return View(values);
		} 

		public async Task<IActionResult> PropertyDetail(int id)
		{ 
			ViewBag.i=id;
			var values=await _propertyService.GetByIdPropertyAsync(id); 
			return View(values);	
		}
		[HttpPost]
		public async Task<IActionResult> PropertyListWithSearch(int propertyCategoryıd, string Type)
		{ 
			var values=await _propertyService.ResultProductWithSearchList(propertyCategoryıd, Type);
			return View(values);
		}
	}
}
