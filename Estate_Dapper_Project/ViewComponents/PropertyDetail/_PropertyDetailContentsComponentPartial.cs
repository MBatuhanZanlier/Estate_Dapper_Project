using Estate_Dapper_Project.Services.PropertyServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.PropertyDetail
{
    public class _PropertyDetailContentsComponentPartial:ViewComponent
    {  
        private readonly IPropertyService _propertyService;

        public _PropertyDetailContentsComponentPartial(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values=await _propertyService.GetByIdPropertyAsync(id); 
            return View(values);
        }
    }
}
