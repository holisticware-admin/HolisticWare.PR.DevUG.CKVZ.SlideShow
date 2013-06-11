using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using HolisticWare.SlideShow.EXE.Controllers;

namespace HolisticWare.SlideShow.EXE
{
	public partial class Screen : Form
	{
		public Screen()
		{
			InitializeComponent();

			// Controller
			textBoxUrlWebService.Text = WebServiceClientProxy.Url;
		}

	}
}
