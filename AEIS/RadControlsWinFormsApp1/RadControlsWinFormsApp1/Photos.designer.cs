namespace AEIS
{
    partial class Photos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Photos));
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.ImgFour = new Emgu.CV.UI.ImageBox();
            this.ImgTwo = new Emgu.CV.UI.ImageBox();
            this.ImgThree = new Emgu.CV.UI.ImageBox();
            this.ImgOne = new Emgu.CV.UI.ImageBox();
            this.imgCameraView = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapture4 = new Telerik.WinControls.UI.RadButton();
            this.btnCapture3 = new Telerik.WinControls.UI.RadButton();
            this.btnCapture2 = new Telerik.WinControls.UI.RadButton();
            this.btnCapture1 = new Telerik.WinControls.UI.RadButton();
            this.btnSaveImages = new Telerik.WinControls.UI.RadButton();
            this.office2010Theme1 = new Telerik.WinControls.Themes.Office2010Theme();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCanddate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveImages)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radLabel4.Location = new System.Drawing.Point(46, 16);
            this.radLabel4.Name = "radLabel4";
            // 
            // 
            // 
            this.radLabel4.RootElement.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radLabel4.Size = new System.Drawing.Size(303, 23);
            this.radLabel4.TabIndex = 16;
            this.radLabel4.Text = "Candidate Photograph Capturing Center";
            this.radLabel4.ThemeName = "Office2007Black";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(661, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 24);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.ThemeName = "Office2010";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.Controls.Add(this.ImgFour);
            this.radGroupBox4.Controls.Add(this.ImgTwo);
            this.radGroupBox4.Controls.Add(this.ImgThree);
            this.radGroupBox4.Controls.Add(this.ImgOne);
            this.radGroupBox4.Controls.Add(this.imgCameraView);
            this.radGroupBox4.Controls.Add(this.label1);
            this.radGroupBox4.Controls.Add(this.btnCapture4);
            this.radGroupBox4.Controls.Add(this.btnCapture3);
            this.radGroupBox4.Controls.Add(this.btnCapture2);
            this.radGroupBox4.Controls.Add(this.btnCapture1);
            this.radGroupBox4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox4.FooterImageIndex = -1;
            this.radGroupBox4.FooterImageKey = "";
            this.radGroupBox4.HeaderImageIndex = -1;
            this.radGroupBox4.HeaderImageKey = "";
            this.radGroupBox4.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox4.HeaderText = "Camera View";
            this.radGroupBox4.Location = new System.Drawing.Point(46, 45);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox4.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox4.Size = new System.Drawing.Size(700, 367);
            this.radGroupBox4.TabIndex = 15;
            this.radGroupBox4.Text = "Camera View";
            this.radGroupBox4.ThemeName = "BreezeExtended";
            this.radGroupBox4.Click += new System.EventHandler(this.radGroupBox4_Click);
            // 
            // ImgFour
            // 
            this.ImgFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgFour.BackgroundImage")));
            this.ImgFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgFour.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgFour.InitialImage")));
            this.ImgFour.Location = new System.Drawing.Point(533, 169);
            this.ImgFour.Name = "ImgFour";
            this.ImgFour.Size = new System.Drawing.Size(140, 140);
            this.ImgFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgFour.TabIndex = 17;
            this.ImgFour.TabStop = false;
            // 
            // ImgTwo
            // 
            this.ImgTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgTwo.BackgroundImage")));
            this.ImgTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgTwo.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgTwo.InitialImage")));
            this.ImgTwo.Location = new System.Drawing.Point(533, 23);
            this.ImgTwo.Name = "ImgTwo";
            this.ImgTwo.Size = new System.Drawing.Size(140, 140);
            this.ImgTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgTwo.TabIndex = 17;
            this.ImgTwo.TabStop = false;
            // 
            // ImgThree
            // 
            this.ImgThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgThree.BackgroundImage")));
            this.ImgThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgThree.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgThree.InitialImage")));
            this.ImgThree.Location = new System.Drawing.Point(387, 169);
            this.ImgThree.Name = "ImgThree";
            this.ImgThree.Size = new System.Drawing.Size(140, 140);
            this.ImgThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgThree.TabIndex = 17;
            this.ImgThree.TabStop = false;
            // 
            // ImgOne
            // 
            this.ImgOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgOne.BackgroundImage")));
            this.ImgOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgOne.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgOne.InitialImage")));
            this.ImgOne.Location = new System.Drawing.Point(387, 23);
            this.ImgOne.Name = "ImgOne";
            this.ImgOne.Size = new System.Drawing.Size(140, 140);
            this.ImgOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgOne.TabIndex = 17;
            this.ImgOne.TabStop = false;
            // 
            // imgCameraView
            // 
            this.imgCameraView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCameraView.Location = new System.Drawing.Point(27, 23);
            this.imgCameraView.Name = "imgCameraView";
            this.imgCameraView.Size = new System.Drawing.Size(335, 234);
            this.imgCameraView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCameraView.TabIndex = 16;
            this.imgCameraView.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(28, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 72);
            this.label1.TabIndex = 15;
            this.label1.Text = "Capture photographs for candidates is handling here. User \r\nshould capture four i" +
                "mages from the camera view. \r\nNote : Incomplete numbers of photos are not suffic" +
                "ient \r\nfor candidate registration.\r\n";
            // 
            // btnCapture4
            // 
            this.btnCapture4.Location = new System.Drawing.Point(582, 330);
            this.btnCapture4.Name = "btnCapture4";
            this.btnCapture4.Size = new System.Drawing.Size(59, 24);
            this.btnCapture4.TabIndex = 14;
            this.btnCapture4.Text = "4";
            this.btnCapture4.ThemeName = "Office2010";
            this.btnCapture4.Click += new System.EventHandler(this.btnCapture4_Click);
            // 
            // btnCapture3
            // 
            this.btnCapture3.Location = new System.Drawing.Point(517, 330);
            this.btnCapture3.Name = "btnCapture3";
            this.btnCapture3.Size = new System.Drawing.Size(59, 24);
            this.btnCapture3.TabIndex = 14;
            this.btnCapture3.Text = "3";
            this.btnCapture3.ThemeName = "Office2010";
            this.btnCapture3.Click += new System.EventHandler(this.btnCapture3_Click);
            // 
            // btnCapture2
            // 
            this.btnCapture2.Location = new System.Drawing.Point(452, 330);
            this.btnCapture2.Name = "btnCapture2";
            this.btnCapture2.Size = new System.Drawing.Size(59, 24);
            this.btnCapture2.TabIndex = 14;
            this.btnCapture2.Text = "2";
            this.btnCapture2.ThemeName = "Office2010";
            this.btnCapture2.Click += new System.EventHandler(this.btnCapture2_Click);
            // 
            // btnCapture1
            // 
            this.btnCapture1.Location = new System.Drawing.Point(387, 330);
            this.btnCapture1.Name = "btnCapture1";
            this.btnCapture1.Size = new System.Drawing.Size(59, 24);
            this.btnCapture1.TabIndex = 14;
            this.btnCapture1.Text = "1";
            this.btnCapture1.ThemeName = "Office2010";
            this.btnCapture1.Click += new System.EventHandler(this.btnCapture1_Click);
            // 
            // btnSaveImages
            // 
            this.btnSaveImages.Location = new System.Drawing.Point(570, 418);
            this.btnSaveImages.Name = "btnSaveImages";
            this.btnSaveImages.Size = new System.Drawing.Size(85, 24);
            this.btnSaveImages.TabIndex = 18;
            this.btnSaveImages.Text = "&Save Images";
            this.btnSaveImages.ThemeName = "Office2010";
            this.btnSaveImages.Click += new System.EventHandler(this.btnSaveImages_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(430, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Candidate ID :";
            // 
            // lblCanddate
            // 
            this.lblCanddate.AutoSize = true;
            this.lblCanddate.ForeColor = System.Drawing.Color.Blue;
            this.lblCanddate.Location = new System.Drawing.Point(512, 26);
            this.lblCanddate.Name = "lblCanddate";
            this.lblCanddate.Size = new System.Drawing.Size(35, 13);
            this.lblCanddate.TabIndex = 20;
            this.lblCanddate.Text = "label3";
            // 
            // Photos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.Silver;
            this.BorderWidth = 5;
            this.ClientSize = new System.Drawing.Size(797, 454);
            this.Controls.Add(this.lblCanddate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.radGroupBox4);
            this.Controls.Add(this.btnSaveImages);
            this.Name = "Photos";
            this.Shape = this.roundRectShapeForm;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photos";
            this.Load += new System.EventHandler(this.Photos_Load);
            this.Leave += new System.EventHandler(this.Photos_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnCapture4;
        private Telerik.WinControls.UI.RadButton btnCapture3;
        private Telerik.WinControls.UI.RadButton btnCapture2;
        private Telerik.WinControls.UI.RadButton btnCapture1;
        private Telerik.WinControls.UI.RadButton btnSaveImages;
        private Telerik.WinControls.Themes.Office2010Theme office2010Theme1;
        private Emgu.CV.UI.ImageBox imgCameraView;
        private Emgu.CV.UI.ImageBox ImgOne;
        private Emgu.CV.UI.ImageBox ImgFour;
        private Emgu.CV.UI.ImageBox ImgTwo;
        private Emgu.CV.UI.ImageBox ImgThree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCanddate;
    }
}