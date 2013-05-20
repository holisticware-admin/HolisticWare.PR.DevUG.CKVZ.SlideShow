using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolisticWare.SlideShow.EXE.Controllers
{
	[HandleError]
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewData["Message"] = "Welcome to ASP.NET MVC!";

			//System.Drawing.Bitmap qrCodeImage = Generate();
			//write your own methode to convert your bit map to byte array, here is a link
			//http://stackoverflow.com/questions/7350679/convert-a-bitmap-into-a-byte-array-in-c
			byte[] byteArray = 
				null
				//ConvertToByteArray(qrCodeImage)
				;
			//return File(byteArray, "image/jpeg");

			return View();
		}

		public ActionResult About()
		{
			return View();
		}
	}
}
