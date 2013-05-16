// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;

namespace PhotoManiaMac
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSImageView imageView { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonPhotoPicker { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonTrashPhoto { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonSendPhoto { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}

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
