using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System.Web.Mvc;

namespace Register_Data_for_Dashboard_Template.Controllers
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

        public ActionResult GetReport(string id)
        {
            // Create new report
            var report = new StiReport();

            // Load report template
            report.Load(Server.MapPath("~/Dashboards/Dashboard.mrt"));

            // Load a JSON file
            var jsonBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Dashboards/Demo.json"));

            // Get DataSet from JSON file
            var json = StiJsonConnector.Get();
            var dataSet = json.GetDataSet(new StiJsonOptions(jsonBytes));

            // Remove all connections from the report template
            report.Dictionary.Databases.Clear();

            // Register DataSet object
            report.RegData("Demo", "Demo", dataSet);

            // Return template to the Viewer
            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}