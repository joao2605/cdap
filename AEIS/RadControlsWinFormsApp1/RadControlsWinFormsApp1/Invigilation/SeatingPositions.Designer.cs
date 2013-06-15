namespace AEIS
{
    partial class SeatingPositions
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
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.breezeExtendedTheme1 = new Telerik.WinControls.Themes.BreezeExtendedTheme();
            this.gvSeatingPositions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSeatingPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(678, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 22);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.ThemeName = "Office2010";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radLabel4.Location = new System.Drawing.Point(29, 12);
            this.radLabel4.Name = "radLabel4";
            // 
            // 
            // 
            this.radLabel4.RootElement.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radLabel4.Size = new System.Drawing.Size(181, 23);
            this.radLabel4.TabIndex = 12;
            this.radLabel4.Text = "Seating Position Details";
            this.radLabel4.ThemeName = "Office2007Black";
            this.radLabel4.Click += new System.EventHandler(this.radLabel4_Click);
            // 
            // gvSeatingPositions
            // 
            this.gvSeatingPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSeatingPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSeatingPositions.Location = new System.Drawing.Point(29, 41);
            this.gvSeatingPositions.Name = "gvSeatingPositions";
            this.gvSeatingPositions.Size = new System.Drawing.Size(749, 223);
            this.gvSeatingPositions.TabIndex = 14;
            // 
            // SeatingPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderColor = System.Drawing.Color.Silver;
            this.BorderWidth = 5;
            this.ClientSize = new System.Drawing.Size(804, 329);
            this.Controls.Add(this.gvSeatingPositions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.radLabel4);
            this.Name = "SeatingPositions";
            this.Shape = this.roundRectShapeForm;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsWindow";
            this.Load += new System.EventHandler(this.SeatingPositions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSeatingPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.Themes.BreezeExtendedTheme breezeExtendedTheme1;
        private System.Windows.Forms.DataGridView gvSeatingPositions;
    }
}