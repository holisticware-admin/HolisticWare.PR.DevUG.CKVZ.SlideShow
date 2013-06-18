// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace PhotoMania
{
	[Register ("ImageViewController")]
	partial class ImageViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem buttonPhotoPicker { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem buttonTrashPhoto { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem buttonSendPhoto { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonPhotoPicker != null) {
				buttonPhotoPicker.Dispose ();
				buttonPhotoPicker = null;
			}

			if (buttonTrashPhoto != null) {
				buttonTrashPhoto.Dispose ();
				buttonTrashPhoto = null;
			}

			if (buttonSendPhoto != null) {
				buttonSendPhoto.Dispose ();
				buttonSendPhoto = null;
			}

			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
		}
	}
}
