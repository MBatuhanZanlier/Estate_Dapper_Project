using Estate_Dapper_Project.Dtos.ServiceDtos;
using Estate_Dapper_Project.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.Areas.EstateAdmin.Controllers
{
    [Area("EstateAdmin")]
    public class ServiceController : Controller
    { 
        private readonly IServiceService _ServiceService;

        public ServiceController(IServiceService serviceService)
        {
            _ServiceService = serviceService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _ServiceService.GetAllServiceAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateService()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto Service)
        {
            await _ServiceService.CreateServiceAsync(Service);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteService(int id)
        {
            await _ServiceService.DeleteServiceAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var values = await _ServiceService.GetByIdServiceAsync(id);
            return View(values);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto ServiceDto)
        {
            await _ServiceService.UpdateService(ServiceDto);
            return RedirectToAction("Index");

        }
    }
}
