using System.Web;
using System.Web.Mvc;

namespace HolisticWare.SlideShow.EXE_ASPnetMVC4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}