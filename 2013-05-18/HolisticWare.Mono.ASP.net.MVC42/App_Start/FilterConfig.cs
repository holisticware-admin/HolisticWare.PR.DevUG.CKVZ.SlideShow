using System.Web;
using System.Web.Mvc;

namespace HolisticWare.Mono.ASP.net.MVC42
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}