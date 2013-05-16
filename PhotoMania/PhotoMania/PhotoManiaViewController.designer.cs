// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace PhotoMania
{
	[Register ("PhotoManiaViewController")]
	partial class PhotoManiaViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton photoPicker { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (photoPicker != null) {
				photoPicker.Dispose ();
				photoPicker = null;
			}
		}
	}
}
