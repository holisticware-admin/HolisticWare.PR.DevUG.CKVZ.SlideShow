using System;
using Gtk;

namespace HolisticWare.SlideShow.EXE
{

	public partial class Screen 
	{
		HolisticWare.SlideShow.BusinessLogic.FileUploaderDownloader fud = null;
		string filename_absolute = null;

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
		private void buttonSendUploadToUrlWebService_Clicked(object sender, EventArgs e)
		{
			if (textBoxImageNamePickedTaken.Text != string.Empty)
			{
				string webserivce = textBoxUrlWebService.Text;
				string filename = textBoxImageNamePickedTaken.Text;

				fud = new HolisticWare.SlideShow.BusinessLogic.FileUploaderDownloader();
				fud.UploadFile(webserivce, filename_absolute);
				fud.MessagesChanged += new EventHandler(fud_MessagesChanged);
			}
			else
			{
				// Gtk.MessageDialog.Show("You must select a file first.", "No File Selected");
				Console.WriteLine("You must select a file first." + "No File Selected");
			}

			return;
		}

		void fud_MessagesChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(fud.Messages[0], fud.Messages[1]);
			Console.WriteLine("Message = " + fud.Messages[0] + " " + fud.Messages[1]);

			return;
		}

	}
}