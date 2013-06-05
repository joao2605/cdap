using System.Drawing.Drawing2D;
namespace AEIS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnMcqHandling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRecognition = new System.Windows.Forms.Button();
            this.btnExaminations = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.pnlBackGround = new System.Windows.Forms.Panel();
            this.pnlFunctionViewr = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUserHandling = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlHedder = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlBackGround.SuspendLayout();
            this.pnlHedder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 3);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 3);
            this.panel2.TabIndex = 3;
            // 
            // btnCandidates
            // 
            this.btnCandidates.BackColor = System.Drawing.SystemColors.Control;
            this.btnCandidates.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCandidates.FlatAppearance.BorderSize = 2;
            this.btnCandidates.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCandidates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnCandidates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidates.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCandidates.Location = new System.Drawing.Point(79, 70);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(135, 35);
            this.btnCandidates.TabIndex = 4;
            this.btnCandidates.Text = "CANDIDATES";
            this.btnCandidates.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCandidates.UseVisualStyleBackColor = false;
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            this.btnCandidates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(985, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "X";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.White;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.Location = new System.Drawing.Point(960, 5);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(26, 25);
            this.btnMini.TabIndex = 6;
            this.btnMini.Text = "_";
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            this.btnMini.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.btnMini.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // btnMcqHandling
            // 
            this.btnMcqHandling.BackColor = System.Drawing.SystemColors.Control;
            this.btnMcqHandling.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMcqHandling.FlatAppearance.BorderSize = 2;
            this.btnMcqHandling.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnMcqHandling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMcqHandling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMcqHandling.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMcqHandling.Location = new System.Drawing.Point(205, 70);
            this.btnMcqHandling.Name = "btnMcqHandling";
            this.btnMcqHandling.Size = new System.Drawing.Size(135, 35);
            this.btnMcqHandling.TabIndex = 7;
            this.btnMcqHandling.Text = "MCQ HANDLING";
            this.btnMcqHandling.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMcqHandling.UseVisualStyleBackColor = false;
            this.btnMcqHandling.Click += new System.EventHandler(this.btnMcqHandling_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 678);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sri Lanka Institute of Information Technology | 4th Year Research Project   | ©Al" +
                "l Rights Reserved - Sachith / Umasha / Shyamike / Thisara\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(7, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 3);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1011, 3);
            this.panel4.TabIndex = 3;
            // 
            // btnRecognition
            // 
            this.btnRecognition.BackColor = System.Drawing.SystemColors.Control;
            this.btnRecognition.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRecognition.FlatAppearance.BorderSize = 2;
            this.btnRecognition.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnRecognition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnRecognition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecognition.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRecognition.Location = new System.Drawing.Point(331, 70);
            this.btnRecognition.Name = "btnRecognition";
            this.btnRecognition.Size = new System.Drawing.Size(135, 35);
            this.btnRecognition.TabIndex = 10;
            this.btnRecognition.Text = "RECOGNITION";
            this.btnRecognition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecognition.UseVisualStyleBackColor = false;
            this.btnRecognition.Click += new System.EventHandler(this.btnRecognition_Click);
            // 
            // btnExaminations
            // 
            this.btnExaminations.BackColor = System.Drawing.SystemColors.Control;
            this.btnExaminations.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExaminations.FlatAppearance.BorderSize = 2;
            this.btnExaminations.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnExaminations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnExaminations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminations.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExaminations.Location = new System.Drawing.Point(457, 70);
            this.btnExaminations.Name = "btnExaminations";
            this.btnExaminations.Size = new System.Drawing.Size(135, 35);
            this.btnExaminations.TabIndex = 11;
            this.btnExaminations.Text = "EXAMINATIONS";
            this.btnExaminations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExaminations.UseVisualStyleBackColor = false;
            this.btnExaminations.Click += new System.EventHandler(this.btnInvigilation_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.Control;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReports.FlatAppearance.BorderSize = 2;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReports.Location = new System.Drawing.Point(583, 70);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(135, 35);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "REPORTS";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.BackColor = System.Drawing.Color.White;
            this.pnlBackGround.Controls.Add(this.pnlFunctionViewr);
            this.pnlBackGround.Location = new System.Drawing.Point(5, 5);
            this.pnlBackGround.Name = "pnlBackGround";
            this.pnlBackGround.Size = new System.Drawing.Size(1014, 690);
            this.pnlBackGround.TabIndex = 14;
            // 
            // pnlFunctionViewr
            // 
            this.pnlFunctionViewr.BackColor = System.Drawing.Color.White;
            this.pnlFunctionViewr.Location = new System.Drawing.Point(0, 99);
            this.pnlFunctionViewr.Name = "pnlFunctionViewr";
            this.pnlFunctionViewr.Size = new System.Drawing.Size(1011, 566);
            this.pnlFunctionViewr.TabIndex = 0;
            this.pnlFunctionViewr.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFunctionViewr_Paint);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(13, 70);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 35);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUserHandling
            // 
            this.btnUserHandling.BackColor = System.Drawing.SystemColors.Control;
            this.btnUserHandling.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnUserHandling.FlatAppearance.BorderSize = 2;
            this.btnUserHandling.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnUserHandling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnUserHandling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserHandling.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUserHandling.Location = new System.Drawing.Point(709, 70);
            this.btnUserHandling.Name = "btnUserHandling";
            this.btnUserHandling.Size = new System.Drawing.Size(135, 35);
            this.btnUserHandling.TabIndex = 15;
            this.btnUserHandling.Text = "USER HANDLING";
            this.btnUserHandling.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserHandling.UseVisualStyleBackColor = false;
            this.btnUserHandling.Click += new System.EventHandler(this.btnUserHandling_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnHelp.FlatAppearance.BorderSize = 2;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.Location = new System.Drawing.Point(830, 70);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(145, 35);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.Text = "HELP AND SUPPORT";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlHedder
            // 
            this.pnlHedder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlHedder.BackgroundImage = global::AEIS.Properties.Resources.cover;
            this.pnlHedder.Controls.Add(this.btnLogout);
            this.pnlHedder.Controls.Add(this.btnSettings);
            this.pnlHedder.Location = new System.Drawing.Point(5, 5);
            this.pnlHedder.Name = "pnlHedder";
            this.pnlHedder.Size = new System.Drawing.Size(1011, 98);
            this.pnlHedder.TabIndex = 13;
            this.pnlHedder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHedder_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(870, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(66, 32);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnSettings.Location = new System.Drawing.Point(800, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(66, 32);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            this.btnSettings.MouseHover += new System.EventHandler(this.btnSettings_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.BorderWidth = 13;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnUserHandling);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCandidates);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnMcqHandling);
            this.Controls.Add(this.btnRecognition);
            this.Controls.Add(this.btnExaminations);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.pnlHedder);
            this.Controls.Add(this.pnlBackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShapedForm1";
            this.Load += new System.EventHandler(this.ShapedForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlBackGround.ResumeLayout(false);
            this.pnlHedder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnMcqHandling;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRecognition;
        private System.Windows.Forms.Button btnExaminations;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlHedder;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private System.Windows.Forms.Panel pnlBackGround;
        private System.Windows.Forms.Button btnUserHandling;
        private System.Windows.Forms.Panel pnlFunctionViewr;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
    }
}