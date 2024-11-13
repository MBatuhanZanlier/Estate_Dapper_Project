using Estate_Dapper_Project.Services.ImagePropertyServices;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.ViewComponents.PropertyDetail
{
    public class _PropertyDetailImagelistComponentPartial:ViewComponent
    { 
        private readonly IImagePropertyService _imagePropertyService;

        public _PropertyDetailImagelistComponentPartial(IImagePropertyService imagePropertyService)
        {
            _imagePropertyService = imagePropertyService;
        } 
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _imagePropertyService.GetAllImageWithProperty(id); 
            return  View(values);
        }
    }
}
