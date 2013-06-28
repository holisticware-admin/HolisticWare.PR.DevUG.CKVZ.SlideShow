using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.IO;

using HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware;
using System.Net;

namespace HolisticWare.SlideShow.BusinessLogic
{
	public partial class FileUploaderDownloader
	{
		// Aside from the default imports, I have added only System.IO to 
		// the list. This being necessary to support working with files. The namespace 
		// and class declarations are in the default configuration. In addition to 
		// System.IO, the project also adds in a web reference pointing to the File 
		// Uploader web service, the reference is given the alias of Uploader.

		// The next bit of code in the class is private method used to prepare the file 
		// for submittal to the web service and to actually make that submittal. The code
		// below is annotated to describe the activity but the essential parts of the 
		// operation are to check the file size to see if the web service will accept the 
		// file (by default, the web server will accept uploads smaller than 4 MB in size, 
		// the web config file must be updated in order to support larger uploads), and to 
		// convert the file to a byte array. When everything is ready, the byte array and 
		// the name of the file including the extension is passed to an instance of the web 
		// service web method.  

		// Note that, when setting up the demo, you will have remove and add the web reference 
		// back into the project in order for it to work for you.

		/// <summary>
		/// Upload any file to the web service; this function may be
		/// used in any application where it is necessary to upload
		/// a file through a web service
		/// </summary>
		/// <param name="filename">Pass the file path to upload</param>
		public void UploadFile(string url, string filename)
		{
			try
			{
				// get the exact file name from the path
				String strFile = System.IO.Path.GetFileName(filename);

				# region    WCF difference
				//-------------------------------------------------------------------------
				// create an instance for the web service WebServiceFileUploader
				WebServiceFileUploader srv = new WebServiceFileUploader();

				srv.Url = url;
				srv.UploadFileCompleted += new UploadFileCompletedEventHandler(srv_UploadFileCompleted);
				//-------------------------------------------------------------------------
				# endregion WCF difference

				byte[] data = FilenameToBytes(filename);
				int size = data.Length / 1024 ;
 
				// Default limit of 4 MB on web server
				// change the web.config to allow larger uploads
				if (size  <= 4000)
				{
					// pass the byte array (file) and file name to the web service
					srv.UploadFileAsync(data, strFile);

					// moved Async!
					// this will always say OK unless an error occurs,
					// if an error occurs, the service returns the error message

					//Messages[0] = "File Upload Status: " + sTmp;
					//Messages[1] = "File Upload";
					// System.Windows.Forms.MessageBox.Show("File Upload Status: " + sTmp, "File Upload");
				}
				else
				{
					// Display message if the file was too large to upload
					//System.Windows.Forms.MessageBox.Show("The file selected exceeds the size limit for uploads.", "File Size");

					Messages = new string[] 
						{ 
						  "The file selected exceeds the size limit for uploads."
						, "File Size" 
						};
				}
			}
			catch (Exception ex)
			{
				// display an error message to the user
				// System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Upload Error");

				Messages = new string[] 
					{
					  ex.Message.ToString()
					, "Upload Error"
					};
			}

			return;
		}

		public void srv_UploadFileCompleted(object sender, UploadFileCompletedEventArgs e)
		{
			// this will always say OK unless an error occurs,
			// if an error occurs, the service returns the error message

			// result of the WebServiceMethod
			string sTmp = e.Result;

			Messages = new string[] 
				{ 
				  "File Upload Status: " + sTmp
				, "File Upload"
				};
			// System.Windows.Forms.MessageBox.Show("File Upload Status: " + sTmp, "File Upload");

			return;
		}
	}
}
