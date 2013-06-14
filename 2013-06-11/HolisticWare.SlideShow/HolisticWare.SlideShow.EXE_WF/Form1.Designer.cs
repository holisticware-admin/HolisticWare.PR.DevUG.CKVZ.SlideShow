namespace HolisticWare.SlideShow.EXE_WF
{
    partial class Form1
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
            this.textBoxUrlWebService = new System.Windows.Forms.TextBox();
            this.buttonSendUploadToUrlWebService = new System.Windows.Forms.Button();
            this.buttonBoxBrowsePickTake = new System.Windows.Forms.Button();
            this.textImageNamePickedTaken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUrlWebService
            // 
            this.textBoxUrlWebService.Location = new System.Drawing.Point(13, 13);
            this.textBoxUrlWebService.Name = "textBoxUrlWebService";
            this.textBoxUrlWebService.Size = new System.Drawing.Size(383, 20);
            this.textBoxUrlWebService.TabIndex = 0;
            // 
            // buttonSendUploadToUrlWebService
            // 
            this.buttonSendUploadToUrlWebService.Location = new System.Drawing.Point(402, 12);
            this.buttonSendUploadToUrlWebService.Name = "buttonSendUploadToUrlWebService";
            this.buttonSendUploadToUrlWebService.Size = new System.Drawing.Size(75, 23);
            this.buttonSendUploadToUrlWebService.TabIndex = 1;
            this.buttonSendUploadToUrlWebService.Text = "Send";
            this.buttonSendUploadToUrlWebService.UseVisualStyleBackColor = true;
            // 
            // buttonBoxBrowsePickTake
            // 
            this.buttonBoxBrowsePickTake.Location = new System.Drawing.Point(402, 48);
            this.buttonBoxBrowsePickTake.Name = "buttonBoxBrowsePickTake";
            this.buttonBoxBrowsePickTake.Size = new System.Drawing.Size(75, 23);
            this.buttonBoxBrowsePickTake.TabIndex = 3;
            this.buttonBoxBrowsePickTake.Text = "Browse";
            this.buttonBoxBrowsePickTake.UseVisualStyleBackColor = true;
            // 
            // textImageNamePickedTaken
            // 
            this.textImageNamePickedTaken.Location = new System.Drawing.Point(13, 49);
            this.textImageNamePickedTaken.Name = "textImageNamePickedTaken";
            this.textImageNamePickedTaken.Size = new System.Drawing.Size(383, 20);
            this.textImageNamePickedTaken.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 286);
            this.Controls.Add(this.buttonBoxBrowsePickTake);
            this.Controls.Add(this.textImageNamePickedTaken);
            this.Controls.Add(this.buttonSendUploadToUrlWebService);
            this.Controls.Add(this.textBoxUrlWebService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrlWebService;
        private System.Windows.Forms.Button buttonSendUploadToUrlWebService;
        private System.Windows.Forms.Button buttonBoxBrowsePickTake;
        private System.Windows.Forms.TextBox textImageNamePickedTaken;
    }
}

