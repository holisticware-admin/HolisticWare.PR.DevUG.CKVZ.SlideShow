using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;


namespace PhotoManiaMac
{
	public partial class MainWindowController : MonoMac.AppKit.NSWindowController
	{
		#region Constructors
		
		// Called when created from unmanaged code
		public MainWindowController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		// Call to load from the XIB/NIB file
		public MainWindowController () : base ("MainWindow")
		{
			Initialize ();


		}
		// Shared initialization code
		void Initialize ()
		{

		}

		#endregion

		//strongly typed window accessor
		public new MainWindow Window 
		{
			get 
			{
				return (MainWindow)base.Window;
			}


		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			buttonPhotoPicker.Activated += LoadPhotoToImageView;
			buttonTrashPhoto.Activated += DeletePhotoFromImageView;
			buttonSendPhoto.Activated += SendPhotoToWebService;
		}

		void SendPhotoToWebService (object sender, EventArgs e)
		{
			//TODO: Mokieeeeeeeeeeeee
		}

		void LoadPhotoToImageView (object sender, EventArgs e)
		{
			var openPanel = new NSOpenPanel();
			openPanel.ReleasedWhenClosed = true;
			openPanel.Prompt = "Select file";

			var result = openPanel.RunModal();

			if (result == 1)
			{

				NSImage image = new NSImage (openPanel.Url);
				imageView.Image = image;


			}

		}

		void DeletePhotoFromImageView (object sender, EventArgs e)
		{
			//REMOVE IMAGE
			imageView.Image = new NSImage ();


		}
	}
}

