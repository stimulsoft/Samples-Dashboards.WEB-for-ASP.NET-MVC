using Stimulsoft.Report.Mvc;
using System.Web.Mvc;

namespace Creating_Dashboard_at_Runtime.Controllers
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
            var appPath = Server.MapPath("~/");
            var dashboard = Helpers.Dashboard.CreateTemplate(appPath);
            return StiMvcDesigner.GetReportResult(dashboard);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }
    }
}