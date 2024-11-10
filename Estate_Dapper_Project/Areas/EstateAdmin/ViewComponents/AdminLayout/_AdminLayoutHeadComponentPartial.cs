using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.Areas.EstateAdmin.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
