using System.Web;
using System.Web.Mvc;

namespace GL.ManagementApp.Presentation.UI.Management
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
