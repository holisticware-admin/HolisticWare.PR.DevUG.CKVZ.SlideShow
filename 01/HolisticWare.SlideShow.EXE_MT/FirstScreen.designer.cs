// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace iOS
{
	[Register ("FirstScreen")]
	partial class FirstScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnOutlet { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField textFieldServer { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField textFieldService { get; set; }

		[Action ("btnAction:")]
		partial void btnAction (MonoTouch.UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnOutlet != null) {
				btnOutlet.Dispose ();
				btnOutlet = null;
			}

			if (textFieldServer != null) {
				textFieldServer.Dispose ();
				textFieldServer = null;
			}

			if (textFieldService != null) {
				textFieldService.Dispose ();
				textFieldService = null;
			}
		}
	}
}
