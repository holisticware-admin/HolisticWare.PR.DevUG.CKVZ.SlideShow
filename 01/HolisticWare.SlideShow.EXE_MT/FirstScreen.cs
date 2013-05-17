
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOS
{
	public partial class FirstScreen : UIViewController
	{
		SecondScreen secondScreen;

		public FirstScreen () : base ("FirstScreen", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			//1. we need to tell navigation controller which screen to push on top
			//	 and in what way (modal, push)
			secondScreen = new SecondScreen();

			//outlet is nothing more that a property
			btnOutlet.TouchUpInside += buttonBrowse_Click;s

			// Text Fields
			//textFieldServer
			//textFieldService

            return;
		}

        private void buttonBrowse_Click (object sender, EventArgs e)
        {
                //push secondScreen on top
                this.NavigationController.PushViewController(secondScreen,true);

                //we could also use modal presentation
                //If you decide to use modal presentation,
                //You need to implement DismissViewController on the screen You
                //decide to present modally.

                //this.NavigationController.PresentViewController(secondScreen,true,null);

            
        }


		//Action
		partial void btnAction (MonoTouch.UIKit.UIButton sender)
		{
            return;
        }
	}
}

