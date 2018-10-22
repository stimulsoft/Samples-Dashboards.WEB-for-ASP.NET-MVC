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

        public ActionResult GetReport(string id)
        {
            var report = Helpers.Dashboard.CreateTemplate();
            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}