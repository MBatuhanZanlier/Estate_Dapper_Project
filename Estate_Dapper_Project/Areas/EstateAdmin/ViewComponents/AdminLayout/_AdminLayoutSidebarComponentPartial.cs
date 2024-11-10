using Microsoft.AspNetCore.Mvc;

namespace Estate_Dapper_Project.Areas.EstateAdmin.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return  View();
        }
    }
}
