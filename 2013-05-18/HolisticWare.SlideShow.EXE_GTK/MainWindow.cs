using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	private Button buttonLoad = null;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		buttonLoad = new Button();
		buttonLoad.Label = "Load";

		return;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
