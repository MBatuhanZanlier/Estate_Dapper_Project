using Estate_Dapper_Project.Dtos.LocationDtos;
using Estate_Dapper_Project.Services.LocationServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.Areas.EstateAdmin.Controllers
{
    [Area("EstateAdmin")]
    public class LocationController : Controller
    { 
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _locationService.GetAllLocationAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateLocation()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationDto Location)
        {
            await _locationService.CreateLocationAsync(Location);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteLocation(int id)
        {
            await _locationService.DeleteLocationAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateLocation(int id)
        {
            var values = await _locationService.GetByIdLocationAsync(id);
            return View(values);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateLocation(UpdateLocationDto LocationDto)
        {
            await _locationService.UpdateLocation(LocationDto);
            return RedirectToAction("Index");

        }
    }
}
