using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HolisticWare.SlideShow.EXE.Models;

namespace HolisticWare.SlideShow.EXE.Controllers
{
	public class ImageController : Controller
	{

		//

		// GET: /Image/

		public ActionResult Index()
		{

			return View(new Images());

		}

		public ActionResult Add()
		{

			return View();

		}

		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Save()
		{

			foreach (string name in Request.Files)
			{
				HttpPostedFileBase file = Request.Files[name];

				string fileName = System.IO.Path.GetFileName(file.FileName);

				Image image = new Image(fileName, Request["description"]);

				Images model = new Images();
				model.Add(image, file);

			}

			return RedirectToAction("index");

		}

		public ActionResult Update()
		{

			return View();

		}
	}
}
