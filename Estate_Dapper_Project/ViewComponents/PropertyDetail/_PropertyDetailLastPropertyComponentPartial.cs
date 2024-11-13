using Estate_Dapper_Project.Services.PropertyServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.PropertyDetail
{
    public class _PropertyDetailLastPropertyComponentPartial:ViewComponent
    {  private readonly IPropertyService _propertyService;

        public _PropertyDetailLastPropertyComponentPartial(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public async Task<IViewComponentResult> InvokeAsync()  
        {
            var values = await _propertyService.GetAllLast2Property();
            return View(values);  
        }
    }
}
