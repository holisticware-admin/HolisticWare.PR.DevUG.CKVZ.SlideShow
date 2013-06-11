using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using HolisticWare.SlideShow.BusinessLogic;
using HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware;


namespace HolisticWare.SlideShow.EXE
{
	public partial class Screen : Form
	{
		public Screen()
		{
			InitializeComponent();

			// Controller
			textBoxUrlWebService.Text = WebServiceClientProxy.Url;

			return;
		}
		
	}
}
