using System.Web;
using System.Web.Mvc;

namespace Registering_a_Data_for_the_Dashboard
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
