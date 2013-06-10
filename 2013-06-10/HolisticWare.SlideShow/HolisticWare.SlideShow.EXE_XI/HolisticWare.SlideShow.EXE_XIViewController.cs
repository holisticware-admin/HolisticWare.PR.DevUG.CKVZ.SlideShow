using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HolisticWare.SlideShow.EXE_XI
{
	public partial class HolisticWare_SlideShow_EXE_XIViewController : UIViewController
	{
		public HolisticWare_SlideShow_EXE_XIViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		#region View lifecycle
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			buttonBoxBrowsePickTake.Clicked += ChooseOrTakePicture;


		}

		void ChooseOrTakePicture (object sender, EventArgs e)
		{
			UIAlertView alert = new UIAlertView ("Media Chooser", "Camera Or Library", null, "Cancel", "Camera", "Library");
			alert.Show ();

			alert.Clicked += MediaChooser;

		}

		void MediaChooser (object sender, UIButtonEventArgs e)
		{
			if (e.ButtonIndex == 1) {
			
				System.Console.WriteLine ("Camera");


			} else if (e.ButtonIndex == 2) {
			
				System.Console.WriteLine ("Library");

			}
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
		#endregion
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

