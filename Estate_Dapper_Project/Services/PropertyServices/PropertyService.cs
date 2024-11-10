using Estate_Dapper_Project.Context;

namespace Estate_Dapper_Project.Services.PropertyServices
{
    public class PropertyService
    {
        private readonly DapperContext _context;

        public PropertyService(DapperContext context)
        {
            _context = context;
        }
    }
}
