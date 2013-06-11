using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.IO;

using HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware;

namespace HolisticWare.SlideShow.BusinessLogic
{
	public partial class FileUploaderDownloader
	{
		public byte[] FilenameToBytes(string filename)
		{
			byte[] data = null;

			// get the file information form the selected file
			FileInfo fInfo = new FileInfo(filename);

			// get the length of the file to see if it is possible
			// to upload it (with the standard 4 MB limit)
			long numBytes = fInfo.Length;
			double dLen = Convert.ToDouble(fInfo.Length / 1000000);

			// set up a file stream and binary reader for the
			// selected file
			FileStream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fStream);

			// convert the file to a byte array
			data = br.ReadBytes((int)numBytes);
			br.Close();

			fStream.Close();
			fStream.Dispose();

			return data;
		}

		//-------------------------------------------------------------------------
		# region Property string[] Messages w Event post (MessagesChanged)
		/// <summary>
		/// Messages
		/// </summary>
		public
		  string[]
		  Messages
		{
			get
			{
				return messages;
			} // Messages.get
			set
			{
				//if (messages != value)		// do not write if equivalent/equal/same
				{
					// for multi threading apps uncomment lines beginnig with //MT:
					//MT: lock(messages) // MultiThread safe				
					{
						messages = value;
						if (null != MessagesChanged)
						{
							MessagesChanged(this, new EventArgs());
						}
					}
				}
			} // Messages.set
		} // Messages

		/// <summary>
		/// private member field for holding Messages data
		/// </summary>
		private
			string[]
			messages
			;

		///<summary>
		/// Event for wiring BusinessLogic object changes and presentation
		/// layer notifications.
		/// MessagesChanged (<propertyname>Changed) is intercepted by Windows Forms
		/// 1.x and 2.0 event dispatcher 
		/// and for some CLR types by WPF event dispatcher 
		/// usually INotifyPropertyChanged and PropertyChanged event
		///</summary>
		public
			event
			EventHandler
			MessagesChanged
			;
		# endregion Property string[] Messages w Event post (MessagesChanged)
		//-------------------------------------------------------------------------	
	}
}
