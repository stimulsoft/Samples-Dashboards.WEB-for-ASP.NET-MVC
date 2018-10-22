using System.Web;
using System.Web.Mvc;

namespace Show_Dashboard_in_the_Viewer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
