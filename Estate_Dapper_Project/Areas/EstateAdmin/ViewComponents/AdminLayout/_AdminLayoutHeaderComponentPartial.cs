using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.Areas.EstateAdmin.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeaderComponentPartial:ViewComponent 
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
