using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;
using HolisticWare.SlideShow.BusinessLogic.TestUploader.Uploader.FileUploader;
using HolisticWare.SlideShow.EXE.ControllerViewModel;

namespace HolisticWare.SlideShow.EXE
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		// Following the UploadFile method, the next bit of code is used to handle 
		// the browse button's click event. This code is used merely to display an open 
		// file dialog to the user and to take the file selected through that dialog and 
		// display the file name in the form's file name text box.
 
		/// <summary>
		/// Allow the user to browse for a file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Open File";
			openFileDialog1.Filter = "All Files|*.*";
			openFileDialog1.FileName = "";
			try
			{
				openFileDialog1.InitialDirectory = 
					//"C:\\Temp"
					@"E:\pics\iphone-4s\"
					;
			}
			catch
			{
				// skip it
			}
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName == "")
				return;
			else
				textBoxFileName.Text = openFileDialog1.FileName; 
		}
 
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
		private void btnUpload_Click(object sender, EventArgs e)
		{
			if (textBoxFileName.Text != string.Empty)
			{
				FileUploaderDownloader fud = new FileUploaderDownloader();
				fud.UploadFile
					(
					  textBoxHostPort.Text
					, textBoxFileName.Text
					);

			}
			else
				MessageBox.Show("You must select a file first.", "No File Selected");
		}
 
		// That wraps up all of the client and server side code necessary to upload 
		// any sort of file to a server from a Win Forms application.
	}
}
