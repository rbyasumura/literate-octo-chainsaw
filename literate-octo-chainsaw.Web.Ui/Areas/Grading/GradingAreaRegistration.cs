using System.Web.Mvc;

namespace literate_octo_chainsaw.Web.Ui.Areas.Grading
{
    public class GradingAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Grading";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Grading_default",
                "Grading/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
