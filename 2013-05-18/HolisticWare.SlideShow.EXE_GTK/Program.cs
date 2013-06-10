using System;
using Gtk;

namespace HolisticWare.SlideShow.EXE
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			Screen win = new Screen ();
			win.Show ();
			Application.Run ();
		}
	}
}
