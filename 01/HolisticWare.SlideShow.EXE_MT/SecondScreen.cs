
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOS
{
	public partial class SecondScreen : UIViewController
	{
		UIImagePickerController imagePicker = new UIImagePickerController();

		public SecondScreen () : base ("SecondScreen", null)
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

			//Create NavigationItems programatically
			UIBarButtonItem rightBarButton = new UIBarButtonItem(UIBarButtonSystemItem.Camera);
			this.NavigationItem.RightBarButtonItem = rightBarButton;

			//Create action(event) for rightBarButton 
			//SELECT picture OR TAKE picture
			rightBarButton.Clicked += (object sender, EventArgs e) => 
			{
				AttachPicture();
				NavigationController.PresentViewController(imagePicker,true,null);
			};


			//Toolbar buttons, added via XCode
			btnDeleteImage.Clicked += (object sender, EventArgs e) => 
			{
				imageView.Image = null;
			};

			btnSendImage.Clicked += (object sender, EventArgs e) => 
			{
				new UIAlertView("!! WARNING !!", "Do You Want To Send Image",null,"Cancel","Send").Show();
			};

		}

		private void AttachPicture()
		{
			bool isAvailable = UIImagePickerController.IsCameraDeviceAvailable (UIImagePickerControllerCameraDevice.Front) || UIImagePickerController.IsCameraDeviceAvailable (UIImagePickerControllerCameraDevice.Rear);		
			
			if(isAvailable)
			{
				imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary | UIImagePickerControllerSourceType.Camera;
			}
			else
				imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
			
			imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes (UIImagePickerControllerSourceType.PhotoLibrary);
			
			imagePicker.FinishedPickingMedia += Handle_FinishedPickingMedia;
			imagePicker.Canceled += Handle_Canceled;
			
			return;
		}

		protected void Handle_FinishedPickingMedia (object sender, UIImagePickerMediaPickedEventArgs e)
		{
			// determine what was selected, video or image
			bool isImage = false;
			switch(e.Info[UIImagePickerController.MediaType].ToString()) {
			case "public.image":
				Console.WriteLine("Image selected");
				isImage = true;
				break;
			case "public.video":
				Console.WriteLine("Video selected");
				break;
			}
			
			// get common info (shared between images and video)
			NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerReferenceUrl")] as NSUrl;
			if (referenceURL != null)
				Console.WriteLine("Url:"+referenceURL.ToString ());
			
			UIImage originalImage = null;
			// if it was an image, get the other image info
			if(isImage) {
				// get the original image
				originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
				if(originalImage != null) {
					// do something with the image
					Console.WriteLine ("got the original image");
					imageView.Image = originalImage; // display
				}
			} else { // if it's a video
				// get video url
				NSUrl mediaURL = e.Info[UIImagePickerController.MediaURL] as NSUrl;
				if(mediaURL != null) {
					Console.WriteLine(mediaURL.ToString());
				}
			}          
			// dismiss the picker
			imagePicker.DismissModalViewControllerAnimated (true);
			
			
			# region    ImageStore
			//-------------------------------------------------------------------------
			//image_store.ImagesMapping.Add("dasdad", originalImage);

			//-------------------------------------------------------------------------
			# endregion ImageStore
			
			return;
		}
		
		void Handle_Canceled (object sender, EventArgs e) {
			imagePicker.DismissModalViewControllerAnimated(true);
		}
	}
}

