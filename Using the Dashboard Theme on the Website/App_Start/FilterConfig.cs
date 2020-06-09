using System.Web;
using System.Web.Mvc;

namespace Using_the_Dashboard_Theme_on_the_Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
