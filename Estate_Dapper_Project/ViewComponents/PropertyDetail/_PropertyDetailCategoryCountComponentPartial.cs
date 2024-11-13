using Estate_Dapper_Project.Services.PropertyServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.PropertyDetail
{
    public class _PropertyDetailCategoryCountComponentPartial:ViewComponent
    {
        private readonly IPropertyService _propertyservice;

        public _PropertyDetailCategoryCountComponentPartial(IPropertyService propertyservice)
        {
            _propertyservice = propertyservice;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values=await _propertyservice.GetPropertyWithCategoryCount(); 
            return View(values);
        }
    }
}
