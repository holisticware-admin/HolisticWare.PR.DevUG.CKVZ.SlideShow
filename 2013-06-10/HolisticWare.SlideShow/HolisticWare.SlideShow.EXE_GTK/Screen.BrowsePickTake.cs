using System;
using Gtk;

namespace HolisticWare.SlideShow.EXE
{

	public partial class Screen 
	{
		void buttonBrowsePickTake_Clicked(object sender, EventArgs e)
		{
			FileChooserDialog fc =
			new FileChooserDialog
				(
				  "Choose the file to open"
				, this
				, FileChooserAction.Open
				, "Cancel", ResponseType.Cancel
				, "Open", ResponseType.Accept
				);

			if (fc.Run() == (int)ResponseType.Accept)
			{
				int l = fc.Filename.LastIndexOf('\\') + 1;
				textBoxImageNamePickedTaken.Text = fc.Filename.Substring(l);
				
				System.IO.FileStream file = System.IO.File.OpenRead(fc.Filename);
				file.Close();
			}
			//Don't forget to call Destroy() or the FileChooserDialog window won't get closed.
			fc.Destroy();

			return;
		}

	}
}