using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System.Web.Mvc;

namespace Export_and_Print_Dashboard_from_Code.Controllers
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

        private StiReport GetDashboard()
        {
            var reportPath = Server.MapPath("~/Dashboards/DashboardChristmas.mrt");
            var report = StiReport.CreateNewDashboard();
            report.Load(reportPath);

            return report;
        }

        public ActionResult PrintPdf()
        {
            var report = this.GetDashboard();
            return StiMvcReportResponse.PrintAsPdf(report);
        }

        public ActionResult ExportPdf()
        {
            var report = this.GetDashboard();
            return StiMvcReportResponse.ResponseAsPdf(report);
        }

        public ActionResult ExportExcel()
        {
            var report = this.GetDashboard();
            return StiMvcReportResponse.ResponseAsExcel2007(report);
        }

        public ActionResult ExportImage()
        {
            var report = this.GetDashboard();
            return StiMvcReportResponse.ResponseAsPng(report);
        }
    }
}