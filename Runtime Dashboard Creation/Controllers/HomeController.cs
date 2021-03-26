using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Runtime_Dashboard_Creation.Controllers
{
    public class HomeController : Controller
    {
        static HomeController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Export()
        {
            var appPath = Server.MapPath("~/");
            var dashboard = Helpers.Dashboard.CreateTemplate(appPath);
            return StiMvcReportResponse.ResponseAsExcel2007(dashboard);
        }
    }
}