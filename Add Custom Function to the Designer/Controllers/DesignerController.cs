using Stimulsoft.Data.Extensions;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Mvc;
using System.Web.Mvc;
using System.Linq;

namespace Add_Custom_Function_to_the_Designer.Controllers
{
    public class DesignerController : Controller
    {
        public static decimal MySum(object value)
        {
            if (!ListExt.IsList(value))
                return Stimulsoft.Base.Helpers.StiValueHelper.TryToDecimal(value);

            return Stimulsoft.Data.Functions.Funcs.SkipNulls(ListExt.ToList(value))
                .TryCastToDecimal()
                .Sum();
        }

        static DesignerController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            // How to add my function
            StiFunctions.AddFunction("MyCategory", "MySum",
                "description", typeof(DesignerController),
                typeof(decimal), "Calculates a sum of the specified set of values.",
                new[] { typeof(object) },
                new[] { "values" },
                new[] { "A set of values" }).UseFullPath = false;
        }

        // GET: Designer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            // Create the dashboard object
            var report = StiReport.CreateNewDashboard();

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