using Estate_Dapper_Project.Dtos.CategoryDtos;
using Estate_Dapper_Project.Dtos.PropertDtos;
using Estate_Dapper_Project.Services.CategoryServices;
using Estate_Dapper_Project.Services.LocationServices;
using Estate_Dapper_Project.Services.PropertyServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Common;


namespace Estate_Dapper_Project.Areas.EstateAdmin.Controllers
{
    [Area("EstateAdmin")]
    public class PropertyController : Controller
    { 
        private readonly IPropertyService _propertyService; 
        private readonly ICategoryService _categoryService; 
        private readonly ILocationService _locationService;

        public PropertyController(IPropertyService propertyService, ICategoryService categoryService, ILocationService locationService)
        {
            _propertyService = propertyService;
            _categoryService = categoryService;
            _locationService = locationService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _propertyService.GetAllPropertyAsync();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> CreateProperty()
        {
            var categoryList =await _categoryService.GetAllCategoryAsync();
            var categoryValues = new SelectList(categoryList, "CategoryID", "CategoryName");
            ViewBag.CategoryValues = categoryValues;
            var LocationList = await _locationService.GetAllLocationAsync();
            var locationValues = new SelectList(LocationList, "LocationID", "LocationName");
            ViewBag.LocationValues = locationValues;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProperty(CreatePropertyDto Property)
        {
            await _propertyService.CreatePropertyAsync(Property);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProperty(int id)
        {
            await _propertyService.DeletePropertyAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProperty(int id)
        {
            var categoryList = await _categoryService.GetAllCategoryAsync();
            var categoryValues = new SelectList(categoryList, "CategoryID", "CategoryName");
            ViewBag.CategoryValues = categoryValues;
            var LocationList = await _locationService.GetAllLocationAsync();
            var locationValues = new SelectList(LocationList, "LocationID", "LocationName");
            ViewBag.LocationValues = locationValues; 

            var values = await _propertyService.GetByIdPropertyAsync(id);
            return View(values);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateProperty(UpdatePropertyDto PropertyDto)
        {
            await _propertyService.UpdateProperty(PropertyDto);
            return RedirectToAction("Index");

        }
    }
}
