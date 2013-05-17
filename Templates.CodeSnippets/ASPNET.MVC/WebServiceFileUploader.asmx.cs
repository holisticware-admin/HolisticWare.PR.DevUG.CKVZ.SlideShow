using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace HolisticWare.SlideShow.EXE
{
	/// <summary>
	/// Summary description for WebServiceFileUploader
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class WebServiceFileUploader : System.Web.Services.WebService
	{
		string path = @"~/Images/";

		// The class starts out with the default imports; I added System.IO to the
		// defaults to support the use of file and memory streams. The web service 
		// namespace is left as the default http://tempuri.org/ which of course will \
		// have to updated if the service were deployed.
		// 
		// The remainder of the code supplied in this class is used to define the web 
		// method used to upload the file; the code is annotated. The essential 
		// process is that, files converted to byte arrays are passed along with the 
		// full name of the file (not the path) including the extention as arguments to 
		// the UploadFile web method. The byte array is passed to a memory stream, and a 
		// file stream is opened pointing to a newly created file (named the name of the 
		// original file) within the target folder used to store the files. Once the file 
		// stream has been created, the memory stream is written into the file stream and
		// then the memory stream and file stream are disposed of.  
		// 
		// The web method is setup to return a string; if all goes well, the string returned
		// will read, "OK", if not, the error message encountered will be returned to the 
		// caller.

		[WebMethod]
		public string UploadFile(byte[] f, string fileName)
		{
			// the byte array argument contains the content of the file
			// the string argument contains the name and extension
			// of the file passed in the byte array
			try
			{
				// instance a memory stream and pass the
				// byte array to its constructor
				MemoryStream ms = new MemoryStream(f);

				// instance a filestream pointing to the
				// storage folder, use the original file name
				// to name the resulting file
				FileStream fs = 
					new FileStream
						(
						  System.Web.Hosting.HostingEnvironment.MapPath(path)
						  + fileName
						, FileMode.Create
						);

				// write the memory stream containing the original
				// file as a byte array to the filestream
				ms.WriteTo(fs);

				// clean up
				ms.Close();
				fs.Close();
				fs.Dispose();

				// return OK if we made it this far
				return "OK";
			}
			catch (Exception ex)
			{
				// return the error message if the operation fails
				return ex.Message.ToString();
			}

			return "N/A";
		}
	}
}