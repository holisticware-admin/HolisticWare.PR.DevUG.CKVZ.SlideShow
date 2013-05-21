using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.UIKit;

namespace System.Windows.Forms 
{
	public partial class MessageBox 
	{
		internal static void Show(string p, string p_2)
		{
			UIAlertView uiav = new UIAlertView("Status", p_2, null, "OK");
			uiav.Show();

			return;
		}
	}
}
