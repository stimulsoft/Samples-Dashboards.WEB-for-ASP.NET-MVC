using System.Web;
using System.Web.Mvc;

namespace Register_Data_for_Dashboard_Template
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
