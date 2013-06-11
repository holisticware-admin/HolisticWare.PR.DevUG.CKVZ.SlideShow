using System.Web;
using System.Web.Mvc;

namespace HolisticWare.Mono.ASP.net.MVC41
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}