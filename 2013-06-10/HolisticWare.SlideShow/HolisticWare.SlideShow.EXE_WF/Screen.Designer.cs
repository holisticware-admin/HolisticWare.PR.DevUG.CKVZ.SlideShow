namespace HolisticWare.SlideShow.EXE_WF
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
            this.buttonSendUploadToUrlWebService = new System.Windows.Forms.Button();
            this.textBoxUrlWebService = new System.Windows.Forms.TextBox();
            this.textImageNamePickedTaken = new System.Windows.Forms.TextBox();
            this.buttonBrowsePickTake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSendUploadToUrlWebService
            // 
            this.buttonSendUploadToUrlWebService.Location = new System.Drawing.Point(137, 48);
            this.buttonSendUploadToUrlWebService.Name = "buttonSendUploadToUrlWebService";
            this.buttonSendUploadToUrlWebService.Size = new System.Drawing.Size(129, 23);
            this.buttonSendUploadToUrlWebService.TabIndex = 0;
            this.buttonSendUploadToUrlWebService.Text = "Send / Upload";
            this.buttonSendUploadToUrlWebService.UseVisualStyleBackColor = true;
            // 
            // textBoxUrlWebService
            // 
            this.textBoxUrlWebService.Location = new System.Drawing.Point(13, 22);
            this.textBoxUrlWebService.Name = "textBoxUrlWebService";
            this.textBoxUrlWebService.Size = new System.Drawing.Size(253, 20);
            this.textBoxUrlWebService.TabIndex = 1;
            this.textBoxUrlWebService.Text = "http://mono-aspnet-mvc4-aws.holisticware.org/WebServiceFileUploader.asmx";
            // 
            // textImageNamePickedTaken
            // 
            this.textImageNamePickedTaken.Location = new System.Drawing.Point(13, 77);
            this.textImageNamePickedTaken.Name = "textImageNamePickedTaken";
            this.textImageNamePickedTaken.Size = new System.Drawing.Size(253, 20);
            this.textImageNamePickedTaken.TabIndex = 3;
            this.textImageNamePickedTaken.Text = "*.jpeg, *.jpg, *.png";
            // 
            // buttonBrowsePickTake
            // 
            this.buttonBrowsePickTake.Location = new System.Drawing.Point(137, 103);
            this.buttonBrowsePickTake.Name = "buttonBrowsePickTake";
            this.buttonBrowsePickTake.Size = new System.Drawing.Size(129, 23);
            this.buttonBrowsePickTake.TabIndex = 2;
            this.buttonBrowsePickTake.Text = "Browse / Pick [Take]";
            this.buttonBrowsePickTake.UseVisualStyleBackColor = true;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.textImageNamePickedTaken);
            this.Controls.Add(this.buttonBrowsePickTake);
            this.Controls.Add(this.textBoxUrlWebService);
            this.Controls.Add(this.buttonSendUploadToUrlWebService);
            this.Name = "Screen";
            this.Text = "Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button buttonSendUploadToUrlWebService;
        private System.Windows.Forms.TextBox textBoxUrlWebService;
        private System.Windows.Forms.TextBox textImageNamePickedTaken;
        private System.Windows.Forms.Button buttonBrowsePickTake;
	}
}

