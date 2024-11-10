using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.Areas.EstateAdmin.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
