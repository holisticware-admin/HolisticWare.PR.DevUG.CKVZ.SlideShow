using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolisticWare.SlideShow.EXE.Models
{
	public partial class Image
	{
		public Image(string path, string desc)
		{
			Path = path;
			Description = desc;
		}
		public string Path { get; set; }
		public string Description { get; set;}
	}
}
