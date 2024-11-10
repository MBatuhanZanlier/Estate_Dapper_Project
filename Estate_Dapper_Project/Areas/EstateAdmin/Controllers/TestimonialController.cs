using Estate_Dapper_Project.Dtos.TestimonialDtos;
using Estate_Dapper_Project.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.Areas.EstateAdmin.Controllers
{
    [Area("EstateAdmin")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _testimonialService.GetAllTestimonialAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto Testimonial)
        {
            await _testimonialService.CreateTestimonialAsync(Testimonial);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonialService.DeleteTestimonialAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var values = await _testimonialService.GetByIdTestimonialAsync(id);
            return View(values);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto TestimonialDto)
        {
            await _testimonialService.UpdateTestimonial(TestimonialDto);
            return RedirectToAction("Index");

        }
    }
}
