using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System.Web.Mvc;

namespace Show_Dashboard_in_the_Viewer.Controllers
{
    public class ViewerController : Controller
    {
        static ViewerController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        // GET: Viewer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            // Create the dashboard object
            var report = StiReport.CreateNewDashboard();

            // Load dashboard template
            report.Load(Server.MapPath("~/Dashboards/DashboardChristmas.mrt"));

            // Return template to the Viewer
            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}