using Stimulsoft.Report.Mvc;
using System.Web.Mvc;

namespace Runtime_Dashboard_Creation.Controllers
{
    public class ViewerController : Controller
    {
        // GET: Viewer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            var appPath = Server.MapPath("~/");
            var dashboard = Helpers.Dashboard.CreateTemplate(appPath);
            return StiMvcViewer.GetReportResult(dashboard);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}