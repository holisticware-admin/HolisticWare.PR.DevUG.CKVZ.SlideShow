using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Xml.Linq;
using System.IO;

namespace HolisticWare.SlideShow.EXE.Models
{
	public partial class Images : List<Image>
	{
		string directory_slides = HttpContext.Current.Server.MapPath("~/Slides/");

		public Images()
		{
			//UpdateFileListFromFile();

			UpdateFileList();

			return;
		}

		private void UpdateFileListFromFile()
		{
			XDocument imageData = XDocument.Load(directory_slides + @"/ImageMetaData.xml");
			IEnumerable<Image> images =
				from image in imageData.Descendants("image")
				select new Image
						(
						  image.Element("filename").Value
						, image.Element("description").Value
						);
			this.AddRange(images.ToList<Image>());
		}

		public void Add(Image image, HttpPostedFileBase filebase)
		{
			filebase.SaveAs(directory_slides + image.Path);
			this.Add(image);
			XElement xml = new XElement
								(
								  "images"
								, from i in this
									  orderby image.Path
									  select new XElement
													(
													  "image"
													, new XElement("filename", i.Path),
													  new XElement("description", i.Description)
													)
								);
			XDocument doc = new XDocument(xml);
			doc.Save(directory_slides + "/ImageMetaData.xml");

			return;
		}

		public void UpdateFileList()
		{
			DirectoryInfo di = new DirectoryInfo(directory_slides);
			foreach (FileInfo fi in di.GetFiles())
			{
				string ext = fi.Extension.ToLower();
				if
					(
					  ext == ".jpg" 
					  || 
					  ext == ".jpeg" 
					  ||
					  ext == ".png"
					)
				{
					Image img = new Image(fi.Name, fi.Name);
					this.Add(img);
				}
			}

			return;
		}
	}
}