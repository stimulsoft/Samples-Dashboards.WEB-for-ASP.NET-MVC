using Stimulsoft.Report.Mvc;
using System.Web.Mvc;

namespace Runtime_Dashboard_Creation.Controllers
{
    public class DesignerController : Controller
    {
        // GET: Designer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            var report = Helpers.Dashboard.CreateTemplate();
            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }
    }
}