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
		public Images()
		{
			string directoryOfImage = HttpContext.Current.Server.MapPath("~/App_Data/Images/");
			XDocument imageData = XDocument.Load(directoryOfImage + @"/ImageMetaData.xml");
			IEnumerable<Image> images = 
				from image in imageData.Descendants("image")
					select new Image
							(
								image.Element("filename").Value
							, image.Element("description").Value
							);
			this.AddRange(images.ToList<Image>());

			UpdateFileList();

			return;
		}

		public void Add(Image image, HttpPostedFileBase filebase)
		{
			string imagerep = HttpContext.Current.Server.MapPath("~/App_Data/Images/");
			filebase.SaveAs(imagerep + image.Path);
			this.Add(image);
			XElement xml = new XElement("images", from i in this
												  orderby image.Path
												  select new XElement("image",
													  new XElement("filename", i.Path),
													  new XElement("description", i.Description))
													 );
			XDocument doc = new XDocument(xml);
			doc.Save(imagerep + "/ImageMetaData.xml");

			return;
		}

		public void UpdateFileList()
		{
			string directory_images = HttpContext.Current.Server.MapPath("~/App_Data/Images/");

			XElement xml_images = new XElement("images");

			DirectoryInfo di = new DirectoryInfo(directory_images);
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