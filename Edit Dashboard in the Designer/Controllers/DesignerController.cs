using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System.Web.Mvc;

namespace Edit_Dashboard_in_the_Designer.Controllers
{
    public class DesignerController : Controller
    {
        static DesignerController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        // GET: Designer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            // Create the report object
            var report = new StiReport();

            // Load dashboard template
            report.Load(Server.MapPath("~/Dashboards/DashboardChristmas.mrt"));

            // Return template to the Designer
            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }
    }
}