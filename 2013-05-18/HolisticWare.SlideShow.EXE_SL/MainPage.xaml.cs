using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using HolisticWare.SlideShow.BusinessLogic;

namespace HolisticWare.SlideShow.EXE_SL
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void buttonBrowse_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Controls.OpenFileDialog openFileDialog1 = new System.Windows.Controls.OpenFileDialog();

			string filename  = "";

			// SL - N/A
			// openFileDialog1.Title = "Open File";			// SL - N/A

			// WF + WPF
			// openFileDialog1.FileName = filename;
			// SL
			//openFileDialog1.File;

			openFileDialog1.Filter =
								"JPEG Files (.jpg)|*.jpg"
								+ "|" +
								"JPEG Files (.jpeg)|*.jpeg"
								+ "|" +
								"PNG Files (.png)|*.png"
								//"All Files (*.*)|*.*"
								;
			openFileDialog1.FilterIndex = 1;
			try
			{
				// SL - N/A
				// openFileDialog1.InitialDirectory =
				// 	//"C:\\Temp"
				// 	@"E:\pics\iphone-4s\"
				// 	;
			}
			catch
			{
				// skip it
			}

			openFileDialog1.ShowDialog();
			
			// WF + WPF
			// filename = openFileDialog1.FileName;
			// SL
			filename = openFileDialog1.File.ToString();

			if (filename == "")
			{
				// OK
			}
			else
			{
				// SL - N/A
				// textBoxFileName.Text = openFileDialog1.FileName;
				textImageNamePickedTaken.Text = openFileDialog1.File.ToString();
			}

			return;
		}

		FileUploaderDownloader fud = null;

		private void buttonUpload_Click(object sender, RoutedEventArgs e)
		{
			if (textImageNamePickedTaken.Text != string.Empty)
			{
				string webserivce = textBoxUrlWebService.Text;
				string filename = textImageNamePickedTaken.Text;
				string[] retval = null;

				fud = new FileUploaderDownloader();
				fud.MessagesChanged += new EventHandler(fud_MessagesChanged);
				fud.UploadFile(webserivce, filename);
			}
			else
			{
				// MessageBox.Show("Select a file first.", "No File Selected");
				MessageBox.Show(null, "No File Selected");

			}

			return;

		}

		void fud_MessagesChanged(object sender, EventArgs e)
		{
			// MessageBox.Show(fud.Messages[0], fud.Messages[1]);
			MessageBox.Show(null , fud.Messages[1]);

		}
	}
}
