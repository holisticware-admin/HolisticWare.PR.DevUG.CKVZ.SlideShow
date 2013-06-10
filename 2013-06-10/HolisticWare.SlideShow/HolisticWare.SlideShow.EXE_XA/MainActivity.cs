using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Media;
using System.Threading.Tasks;
using Android.Graphics;
using System.IO;

namespace HolisticWare.SlideShow.EXE
{
	[Activity (Label = "HolisticWare.SlideShow.EXE", MainLauncher = true)]
	public class MainActivity : Activity
	{

		ImageView imageView;
		Bitmap b;
		MemoryStream stream;

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

			imageView = FindViewById<ImageView> (Resource.Id.imageView);
			buttonBoxBrowsePickTake.Click +=  MediaChooser;

		
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
										else {
											picker.TakePhotoAsync (new StoreCameraMediaOptions {
											Name = "test.jpg",
											Directory = "MediaPickerSample"
											}).ContinueWith (t => {
							
											if (t.IsCanceled) {
											Console.WriteLine ("User canceled");
											return;
											}

											Console.WriteLine (t.Result.Path);
											b = BitmapFactory.DecodeFile(t.Result.Path);
											imageView.SetImageBitmap(b);

											}, TaskScheduler.FromCurrentSynchronizationContext());
										}
										
										//MOKEEEEEE Bitmap TO Array
										stream = new MemoryStream();
										b.Compress(Bitmap.CompressFormat.Png, 0, stream);
										byte[] bitmapData = stream.ToArray();

										}
			);

			builder.SetNeutralButton("Library"
			                         	,
			                         delegate 
			                         {
										var picker = new MediaPicker (this);
								//           new MediaPicker (this); on Android

										picker.PickPhotoAsync()
											.ContinueWith (t => {
												if (t.IsCanceled) {
												Console.WriteLine ("User canceled");
												return;
										}

										Console.WriteLine (t.Result.Path);
										b = BitmapFactory.DecodeFile(t.Result.Path);
										imageView.SetImageBitmap(b);

									}, TaskScheduler.FromCurrentSynchronizationContext());

									//MOKEEEEEE Bitmap TO Array
									stream = new MemoryStream();
									b.Compress(Bitmap.CompressFormat.Png, 0, stream);
									byte[] bitmapData = stream.ToArray();

							}
		
			);



			builder.SetNegativeButton("Cancel",delegate {});

			builder.Show();
		}


	}
}


