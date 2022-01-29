using Stimulsoft.Dashboard.Components;
using Stimulsoft.Report;
using Stimulsoft.Report.Dashboard.Styles;
using Stimulsoft.Report.Mvc;
using System.Drawing;
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
            var dashboardFiles = Directory.GetFiles(Server.MapPath($"/Content/Dashboards"), "*.mrt");
            var fileNames = new string[dashboardFiles.Length];
            var index = 0;
            foreach (var filePath in dashboardFiles)
            {
                fileNames[index++] = Path.GetFileNameWithoutExtension(filePath);
            }

            ViewBag.FileNames = fileNames;

            var fileName = RouteData.Values["id"].ToString();
            var report = StiReport.CreateNewDashboard();
            report.Load(Server.MapPath($"/Content/Dashboards/{fileName}.mrt"));

            var dashboard = report.Pages[0] as StiDashboard;
            ViewBag.ForeHtmlColor = ColorTranslator.ToHtml(dashboard != null ? StiDashboardStyleHelper.GetForeColor(dashboard) : Color.Black);
            ViewBag.BackHtmlColor = ColorTranslator.ToHtml(dashboard != null ? StiDashboardStyleHelper.GetDashboardBackColor(dashboard, true) : Color.White);
            ViewBag.BackColor = dashboard != null ? StiDashboardStyleHelper.GetDashboardBackColor(dashboard, true) : Color.White;

            return View();
        }

        public ActionResult GetReport(string id)
        {
            var report = StiReport.CreateNewDashboard();
            report.Load(Server.MapPath("/Content/Dashboards/" + id + ".mrt"));

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