namespace AEIS
{
    partial class InvigilationSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.severetyTrack = new Telerik.WinControls.UI.RadTrackBar();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.severetyTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(680, 283);
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
            this.radLabel4.Location = new System.Drawing.Point(23, 12);
            this.radLabel4.Name = "radLabel4";
            // 
            // 
            // 
            this.radLabel4.RootElement.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radLabel4.Size = new System.Drawing.Size(153, 23);
            this.radLabel4.TabIndex = 12;
            this.radLabel4.Text = "Invigilation Settings";
            this.radLabel4.ThemeName = "Office2007Black";
            this.radLabel4.Click += new System.EventHandler(this.radLabel4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radLabel1);
            this.groupBox1.Controls.Add(this.severetyTrack);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 224);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(27, 97);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(122, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Show Hand Position";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(27, 120);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(127, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Record Video Stream";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(27, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(133, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Show Motion Changes";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(27, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show Position Numbers";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Names";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(27, 144);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(103, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Show Grid Lines";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // severetyTrack
            // 
            this.severetyTrack.Location = new System.Drawing.Point(410, 28);
            this.severetyTrack.Maximum = 99;
            this.severetyTrack.Minimum = 20;
            this.severetyTrack.Name = "severetyTrack";
            this.severetyTrack.Size = new System.Drawing.Size(276, 31);
            this.severetyTrack.SliderAreaColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(150)))), ((int)(((byte)(194)))));
            this.severetyTrack.SliderAreaColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(150)))), ((int)(((byte)(194)))));
            this.severetyTrack.TabIndex = 11;
            this.severetyTrack.Text = "radTrackBar2";
            this.severetyTrack.TicksColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(150)))), ((int)(((byte)(194)))));
            this.severetyTrack.Value = 30;
            this.severetyTrack.ValueChanged += new System.EventHandler(this.severetyTrack_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(303, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 17);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Alert Severity";
            this.radLabel1.ThemeName = "Office2007Black";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "30";
            // 
            // InvigilationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderColor = System.Drawing.Color.Silver;
            this.BorderWidth = 5;
            this.ClientSize = new System.Drawing.Size(804, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.radLabel4);
            this.Name = "InvigilationSettings";
            this.Shape = this.roundRectShapeForm;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsWindow";
            this.Load += new System.EventHandler(this.SeatingPositions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.severetyTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.Themes.BreezeExtendedTheme breezeExtendedTheme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private Telerik.WinControls.UI.RadTrackBar severetyTrack;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}