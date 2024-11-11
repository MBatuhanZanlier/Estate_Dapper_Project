using Estate_Dapper_Project.Services.PropertyServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.DefaultHomaPage
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {  

        private readonly IPropertyService _propertyService;

        public _DefaultFeatureComponentPartial(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            var values=await _propertyService.GetAlltPropertyFeatures(); 
            return View(values);    
        }
    }
}
