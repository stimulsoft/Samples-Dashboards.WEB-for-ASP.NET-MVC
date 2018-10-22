using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System.IO;
using System.Web.Mvc;

namespace Web_Demo.Controllers
{
    public class ViewController : Controller
    {
        static ViewController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public ActionResult Dashboards()
        {
            var dashboardFiles = Directory.GetFiles(Server.MapPath($"~/Dashboards"), "*.mrt");
            var fileNames = new string[dashboardFiles.Length];
            var index = 0;
            foreach (var filePath in dashboardFiles)
            {
                fileNames[index++] = Path.GetFileNameWithoutExtension(filePath);
            }

            ViewBag.FileNames = fileNames;

            return View();
        }

        public ActionResult GetReport(string id)
        {
            var report = new StiReport();
            report.Load(Server.MapPath($"~/Dashboards/{id}.mrt"));

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }

        public ActionResult Design(string id)
        {
            return RedirectToAction("Dashboards", "Design", new { id });
        }
    }
}