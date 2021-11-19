using System.Web;
using System.Web.Mvc;

namespace Creating_Dashboard_at_Runtime
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
