namespace HolisticWare.SlideShow.EXE
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
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.textBoxFileName = new System.Windows.Forms.TextBox();
			this.buttonUpload = new System.Windows.Forms.Button();
			this.textBoxHostPort = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(81, 28);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(207, 23);
			this.buttonBrowse.TabIndex = 0;
			this.buttonBrowse.Text = "Browse?Pick [Take]";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.InitialDirectory = "E:\\pics\\iphone-4s\\";
			// 
			// textBoxFileName
			// 
			this.textBoxFileName.Location = new System.Drawing.Point(12, 57);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.Size = new System.Drawing.Size(276, 20);
			this.textBoxFileName.TabIndex = 1;
			// 
			// buttonUpload
			// 
			this.buttonUpload.Location = new System.Drawing.Point(213, 83);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new System.Drawing.Size(75, 23);
			this.buttonUpload.TabIndex = 2;
			this.buttonUpload.Text = "Upload";
			this.buttonUpload.UseVisualStyleBackColor = true;
			this.buttonUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// textBoxHostPort
			// 
			this.textBoxHostPort.Location = new System.Drawing.Point(12, 83);
			this.textBoxHostPort.Name = "textBoxHostPort";
			this.textBoxHostPort.Size = new System.Drawing.Size(139, 20);
			this.textBoxHostPort.TabIndex = 3;
			this.textBoxHostPort.Text = "localhost:8080";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 125);
			this.Controls.Add(this.textBoxHostPort);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.textBoxFileName);
			this.Controls.Add(this.buttonBrowse);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.Button buttonUpload;
		private System.Windows.Forms.TextBox textBoxHostPort;
	}
}

