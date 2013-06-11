using System;
using Gtk;

namespace HolisticWare.SlideShow.EXE
{

	public partial class Screen : Gtk.Window
	{
		private Fixed fix = null;
		private Entry textBoxImageNamePickedTaken = null;
		private Button buttonBrowsePickTake = null;
		private Entry textBoxUrlWebService = null;
		private Button buttonSendUploadToUrlWebService = null;

		public Screen()
			: base(Gtk.WindowType.Toplevel)
		{
			Build();

			this.SetSizeRequest(500, 100);
			this.DefaultSize = new Gdk.Size(500, 100);

			/* Create a new button */
			buttonBrowsePickTake = new Button();
			buttonSendUploadToUrlWebService = new Button();

			/* Connect the "clicked" signal of the button to our callback */
			buttonBrowsePickTake.Clicked += new EventHandler(buttonBrowsePickTake_Clicked);
			buttonBrowsePickTake.Label = "Load";
			buttonBrowsePickTake.SetSizeRequest(80, 20);

			buttonSendUploadToUrlWebService.Clicked += new EventHandler(buttonSendUploadToUrlWebService_Clicked);
			buttonSendUploadToUrlWebService.Label = "Send";
			buttonSendUploadToUrlWebService.SetSizeRequest(80, 20);

			textBoxImageNamePickedTaken = new Entry("image file");
			textBoxImageNamePickedTaken.SetSizeRequest(320, 20);
			textBoxUrlWebService = new Entry(HolisticWare.SlideShow.BusinessLogic.WebServiceClientProxy.Url);
			textBoxUrlWebService.SetSizeRequest(320, 20);

			fix = new Fixed();

			fix.Put(textBoxImageNamePickedTaken, 20, 20);
			fix.Put(textBoxUrlWebService, 20, 50);
			fix.Put(buttonBrowsePickTake, 360, 20);
			fix.Put(buttonSendUploadToUrlWebService, 360, 50);

			Add(fix);

			this.ShowAll();

			return;
		}

		protected void OnDeleteEvent(object sender, DeleteEventArgs a)
		{
			Application.Quit();
			a.RetVal = true;
		}

	}
}