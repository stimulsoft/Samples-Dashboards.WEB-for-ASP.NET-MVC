using System.Web;
using System.Web.Mvc;

namespace Exporting_a_Dashboard_from_Code
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
