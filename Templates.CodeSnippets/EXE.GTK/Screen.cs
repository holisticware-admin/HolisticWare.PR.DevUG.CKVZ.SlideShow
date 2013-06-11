using System;
using Gtk;

namespace HolisticWare.SlideShow.EXE
{

	public partial class Screen : Gtk.Window
	{
		private Fixed fix = null;
		private Entry textImageNamePickedTaken = null;
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
			buttonLoad = new Button();
			buttonSend = new Button();

			/* Connect the "clicked" signal of the button to our callback */
			buttonLoad.Clicked += new EventHandler(buttonLoad_Clicked);
			buttonLoad.Label = "Load";
			buttonLoad.SetSizeRequest(80, 20);

			buttonSend.Clicked += new EventHandler(buttonSend_Clicked);
			buttonSend.Label = "Send";
			buttonSend.SetSizeRequest(80, 20);

			textBoxLoad = new Entry("image file");
			textBoxLoad.SetSizeRequest(320, 20);
			textBoxSend = new Entry(HolisticWare.SlideShow.BusinessLogic.WebServiceClientProxy.Url);
			textBoxSend.SetSizeRequest(320, 20);

			fix = new Fixed();

			fix.Put(textBoxLoad, 20, 20);
			fix.Put(textBoxSend, 20, 50);
			fix.Put(buttonLoad, 360, 20);
			fix.Put(buttonSend, 360, 50);

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