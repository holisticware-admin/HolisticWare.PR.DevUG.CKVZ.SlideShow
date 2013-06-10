// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace HolisticWare.SlideShow.EXE
{
	[Register ("HolisticWare_SlideShow_EXE_XIViewController")]
	partial class HolisticWare_SlideShow_EXE_XIViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem buttonBoxBrowsePickTake { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem buttonSendUploadToUrlWebService { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem buttonClearImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonBoxBrowsePickTake != null) {
				buttonBoxBrowsePickTake.Dispose ();
				buttonBoxBrowsePickTake = null;
			}

			if (buttonSendUploadToUrlWebService != null) {
				buttonSendUploadToUrlWebService.Dispose ();
				buttonSendUploadToUrlWebService = null;
			}

			if (buttonClearImage != null) {
				buttonClearImage.Dispose ();
				buttonClearImage = null;
			}

			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
		}
	}
}
