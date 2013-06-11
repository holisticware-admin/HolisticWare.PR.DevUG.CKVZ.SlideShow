using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Media;
using Android.Graphics;
using System.Threading.Tasks;

namespace HolisticWare.SlideShow.EXE
{
	[Activity (Label = "Screen", MainLauncher = true)]			
	public class Screen : Activity
	{
		ImageView imageView;
		Bitmap b;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Screen);

			Button buttonBoxBrowsePickTake = FindViewById<Button> (Resource.Id.buttonBoxBrowsePickTake);
			Button buttonSendUploadToUrlWebService = FindViewById<Button> (Resource.Id.buttonSendUploadToUrlWebService);
			imageView = FindViewById<ImageView> (Resource.Id.imageView);

			buttonBoxBrowsePickTake.Click += MediaChooser;

		}

		void MediaChooser (object sender, EventArgs e)
		{
			var builder = new AlertDialog.Builder(this);
			builder.SetTitle("Media Chooser");
			builder.SetMessage("Camera Or Library");
			builder.SetCancelable(false);

			builder.SetPositiveButton("Camera"
			                          , 
			                          delegate 
			                          { 
				var picker = new MediaPicker (this);

				if (!picker.IsCameraAvailable)
					Console.WriteLine ("No camera!");

				else 
				{
					picker.TakePhotoAsync (new StoreCameraMediaOptions {
						Name = "test.jpg",
						Directory = "MediaPickerSample"
					}).ContinueWith (t => {

						if (t.IsCanceled) 
						{
							Console.WriteLine ("User canceled");
							return;
						}

						Console.WriteLine (t.Result.Path);

						//Load image to imageView
						b = BitmapFactory.DecodeFile(t.Result.Path);
						imageView.SetImageBitmap(b);

					}, TaskScheduler.FromCurrentSynchronizationContext());
				}

			}
			);

			builder.SetNeutralButton("Library"
			                         ,
			                         delegate 
			                         {
				var picker = new MediaPicker (this);


				picker.PickPhotoAsync()
					.ContinueWith (t => {

						if (t.IsCanceled) 
						{
							Console.WriteLine ("User canceled");
							return;
						}

						Console.WriteLine (t.Result.Path);
						b = BitmapFactory.DecodeFile(t.Result.Path);
						imageView.SetImageBitmap(b);

					}, TaskScheduler.FromCurrentSynchronizationContext());
			}

			);



			builder.SetNegativeButton("Cancel",delegate {});

			builder.Show();
		}
	}
}

