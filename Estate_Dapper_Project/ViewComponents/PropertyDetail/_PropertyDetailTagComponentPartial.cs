using Estate_Dapper_Project.Services.TagServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.PropertyDetail
{
    public class _PropertyDetailTagComponentPartial:ViewComponent
    {  
        private readonly ITagService _tagService;

        public _PropertyDetailTagComponentPartial(ITagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _tagService.GetAllTagWithProduct(id);
            return View(values);
        }
    }
}
