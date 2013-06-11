using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using HolisticWare.SlideShow.BusinessLogic;
using System.Windows.Forms;


namespace HolisticWare.SlideShow.EXE 
{
	public partial class Screen
	{
		// Following the UploadFile method, the next bit of code is used to handle 
		// the browse button's click event. This code is used merely to display an open 
		// file dialog to the user and to take the file selected through that dialog and 
		// display the file name in the form's file name text box.

		/// <summary>
		/// Allow the user to browse for a file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonBrowsePickTake_Click(object sender, EventArgs e)
		{
			// WF
			System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			// WPF
			// Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
			//SL
			// System.Windows.Controls.OpenFileDialog openFileDialog1 = new System.Windows.Controls.OpenFileDialog();

			string filename = "";

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
			filename = openFileDialog1.FileName;
			// SL
			// filename = openFileDialog1.File.ToString();

			if (filename == "")
			{
				// OK
			}
			else
			{
				// SL - N/A
				textImageNamePickedTaken.Text = openFileDialog1.FileName;
				// textBoxFileName.Text = openFileDialog1.File.ToString();
			}

			return;
		}


		FileUploaderDownloader fud = new FileUploaderDownloader();

		// The class wraps up with the button click event handler for the Upload 
		// button. This handler merely checks for text in the file name text box and, 
		// if something is there, it sends the value to the Upload method.

		/// <summary>
		/// If the user has selected a file, send it to the upload method,
		/// the upload method will convert the file to a byte array and
		/// send it through the web service
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSendUploadToUrlWebService_Click(object sender, EventArgs e)
		{
			if (textImageNamePickedTaken.Text != string.Empty)
			{
				string webserivce = textBoxUrlWebService.Text;
				string filename = textImageNamePickedTaken.Text;

				fud = new FileUploaderDownloader();
				fud.UploadFile(webserivce, filename);
				fud.MessagesChanged += new EventHandler(fud_MessagesChanged);
			}
			else
			{
				MessageBox.Show("You must select a file first.", "No File Selected");
			}

			return;
		}
		
		void fud_MessagesChanged(object sender, EventArgs e)
		{
			MessageBox.Show(fud.Messages[0], fud.Messages[1]);

			return;
		}

		// That wraps up all of the client and server side code necessary to upload 
		// any sort of file to a server from a Win Forms application.
	}
}
