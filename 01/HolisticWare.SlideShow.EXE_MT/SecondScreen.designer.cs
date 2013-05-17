// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace iOS
{
	[Register ("SecondScreen")]
	partial class SecondScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem btnSendImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem btnDeleteImage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}

			if (btnSendImage != null) {
				btnSendImage.Dispose ();
				btnSendImage = null;
			}

			if (btnDeleteImage != null) {
				btnDeleteImage.Dispose ();
				btnDeleteImage = null;
			}
		}
	}
}
