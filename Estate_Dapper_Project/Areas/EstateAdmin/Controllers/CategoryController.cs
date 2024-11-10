using Estate_Dapper_Project.Dtos.CategoryDtos;
using Estate_Dapper_Project.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.Areas.EstateAdmin.Controllers
{

    [Area("EstateAdmin")]
    public class CategoryController : Controller
    { 
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        { 
            var values=await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        { 

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto category)
        {  
            await _categoryService.CreateCategoryAsync(category);
            return RedirectToAction("Index");
        } 

        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)  
        {  
              var values=await _categoryService.GetByIdCategoryAsync(id); 
            return View(values);
        
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto categoryDto )
        {
            await _categoryService.UpdateCategory(categoryDto);
            return RedirectToAction("Index");

        }
    }
}
