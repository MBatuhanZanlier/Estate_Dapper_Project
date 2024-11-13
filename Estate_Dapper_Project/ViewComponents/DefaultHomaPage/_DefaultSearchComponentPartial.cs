using Estate_Dapper_Project.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.DefaultHomaPage
{
	public class _DefaultSearchComponentPartial:ViewComponent
	{  
		private readonly ICategoryService _categoryService;

		public _DefaultSearchComponentPartial(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{ 
			var values=await _categoryService.GetAllCategoryAsync();
			return View(values);
		}
	}
}
