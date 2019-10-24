using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System.Web.Mvc;

namespace Web_Demo.Controllers
{
    public class DesignController : Controller
    {
        static DesignController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }
        
        public ActionResult Dashboards()
        {
            return View();
        }

        public ActionResult GetReport(string id)
        {
            var report = StiReport.CreateNewDashboard();
            report.Load(Server.MapPath($"~/Dashboards/{id}.mrt"));

            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult SaveReport()
        {
            var report = StiMvcDesigner.GetReportObject();

            // string packedReport = report.SavePackedReportToString();
            // ...
            // The save report code here
            // ...

            // Completion of the report saving without dialog box
            return StiMvcDesigner.SaveReportResult();
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }

        public ActionResult ExitDesigner(string id)
        {
            return RedirectToAction("Dashboards", "View", new { id });
        }
    }
}