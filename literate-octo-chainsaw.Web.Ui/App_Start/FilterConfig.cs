using System.Web;
using System.Web.Mvc;

namespace literate_octo_chainsaw.Web.Ui
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
