// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;

namespace HolisticWare.SlideShow.EXE_MM
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSButton buttonBoxBrowsePickTake { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonSendUploadToUrlWebService { get; set; }

		[Outlet]
		MonoMac.AppKit.NSImageView imageView { get; set; }
		
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

			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
