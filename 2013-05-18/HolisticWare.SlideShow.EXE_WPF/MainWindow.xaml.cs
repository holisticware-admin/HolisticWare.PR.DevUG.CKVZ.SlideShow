using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HolisticWare.SlideShow.EXE_WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void buttonBrowse_Click(object sender, RoutedEventArgs e)
		{
			// WF
			// System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			// WPF
			Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
			//SL
			// System.Windows.Controls.OpenFileDialog openFileDialog1 = new System.Windows.Controls.OpenFileDialog();

			string filename = "";

			// SL - N/A
			// openFileDialog1.Title = "Open File";			// SL - N/A

			// WF + WPF
			// openFileDialog1.FileName = filename;
			// SL
			//openFileDialog1.File;

			openFileDialog1.Filter =
								"JPEG Files (.jpg)|*.jpg"
								+ "|" +
								"JPEG Files (.jpeg)|*.jpeg"
								+ "|" +
								"PNG Files (.png)|*.png"
				//"All Files (*.*)|*.*"
								;
			openFileDialog1.FilterIndex = 1;
			try
			{
				// SL - N/A
				// openFileDialog1.InitialDirectory =
				// 	//"C:\\Temp"
				// 	@"E:\pics\iphone-4s\"
				// 	;
			}
			catch
			{
				// skip it
			}

			openFileDialog1.ShowDialog();

			// WF + WPF
			filename = openFileDialog1.FileName;
			// SL
			// filename = openFileDialog1.File.ToString();

			if (filename == "")
			{
				// OK
			}
			else
			{
				// SL - N/A
				textBoxFileName.Text = openFileDialog1.FileName;
				// textBoxFileName.Text = openFileDialog1.File.ToString();
			}

			return;
		}

		private void buttonUpload_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
