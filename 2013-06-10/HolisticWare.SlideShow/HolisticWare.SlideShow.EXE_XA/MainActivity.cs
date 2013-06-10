using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HolisticWare.SlideShow.EXE
{
	[Activity (Label = "HolisticWare.SlideShow.EXE", MainLauncher = true)]
	public class MainActivity : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button> (Resource.Id.myButton);

			Button buttonBoxBrowsePickTake = FindViewById<Button> (Resource.Id.buttonBoxBrowsePickTake);
			Button buttonSendUploadToUrlWebService = FindViewById<Button> (Resource.Id.buttonSendUploadToUrlWebService);

			ImageView imageView = FindViewById<ImageView> (Resource.Id.imageView);
			buttonBoxBrowsePickTake.Click += ChooseOrTakePicture;

		
		}

		void ChooseOrTakePicture (object sender, EventArgs e)
		{
			var builder = new AlertDialog.Builder(this);
			builder.SetTitle("Media Chooser");
			builder.SetMessage("Camera Or Library");
			builder.SetCancelable(false);

			builder.SetPositiveButton("Camera"
			                          , 
			                          delegate 
			                          { 
				//StartActivity(typeof(pnl5000LocationDetail));	
			}
			);

			builder.SetNeutralButton("Library"
			                         ,
			                         delegate 
			                         {

			});
			builder.SetNegativeButton("Cancel",delegate {});

			builder.Show();
		}
	}
}


