using System.Web;
using System.Web.Mvc;

namespace Runtime_Dashboard_Creation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
