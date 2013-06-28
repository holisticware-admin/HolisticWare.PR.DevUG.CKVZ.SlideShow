namespace HolisticWare.SlideShow.EXE
{
	partial class Screen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonBoxBrowsePickTake = new System.Windows.Forms.Button();
			this.textImageNamePickedTaken = new System.Windows.Forms.TextBox();
			this.buttonSendUploadToUrlWebService = new System.Windows.Forms.Button();
			this.textBoxUrlWebService = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonBoxBrowsePickTake
			// 
			this.buttonBoxBrowsePickTake.Location = new System.Drawing.Point(345, 12);
			this.buttonBoxBrowsePickTake.Name = "buttonBoxBrowsePickTake";
			this.buttonBoxBrowsePickTake.Size = new System.Drawing.Size(130, 23);
			this.buttonBoxBrowsePickTake.TabIndex = 0;
			this.buttonBoxBrowsePickTake.Text = "Browse?Pick [Take]";
			this.buttonBoxBrowsePickTake.UseVisualStyleBackColor = true;
			this.buttonBoxBrowsePickTake.Click += new System.EventHandler(this.buttonBrowsePickTake_Click);
			// 
			// textImageNamePickedTaken
			// 
			this.textImageNamePickedTaken.Location = new System.Drawing.Point(12, 15);
			this.textImageNamePickedTaken.Name = "textImageNamePickedTaken";
			this.textImageNamePickedTaken.Size = new System.Drawing.Size(327, 20);
			this.textImageNamePickedTaken.TabIndex = 1;
			// 
			// buttonSendUploadToUrlWebService
			// 
			this.buttonSendUploadToUrlWebService.Location = new System.Drawing.Point(345, 41);
			this.buttonSendUploadToUrlWebService.Name = "buttonSendUploadToUrlWebService";
			this.buttonSendUploadToUrlWebService.Size = new System.Drawing.Size(130, 23);
			this.buttonSendUploadToUrlWebService.TabIndex = 2;
			this.buttonSendUploadToUrlWebService.Text = "Upload";
			this.buttonSendUploadToUrlWebService.UseVisualStyleBackColor = true;
			this.buttonSendUploadToUrlWebService.Click += new System.EventHandler(this.buttonSendUploadToUrlWebService_Click);
			// 
			// textBoxUrlWebService
			// 
			this.textBoxUrlWebService.Location = new System.Drawing.Point(12, 41);
			this.textBoxUrlWebService.Name = "textBoxUrlWebService";
			this.textBoxUrlWebService.Size = new System.Drawing.Size(327, 20);
			this.textBoxUrlWebService.TabIndex = 3;
			// 
			// Screen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 75);
			this.Controls.Add(this.textBoxUrlWebService);
			this.Controls.Add(this.buttonSendUploadToUrlWebService);
			this.Controls.Add(this.textImageNamePickedTaken);
			this.Controls.Add(this.buttonBoxBrowsePickTake);
			this.Name = "Screen";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonBoxBrowsePickTake;
		private System.Windows.Forms.TextBox textImageNamePickedTaken;
		private System.Windows.Forms.Button buttonSendUploadToUrlWebService;
		private System.Windows.Forms.TextBox textBoxUrlWebService;
	}
}

