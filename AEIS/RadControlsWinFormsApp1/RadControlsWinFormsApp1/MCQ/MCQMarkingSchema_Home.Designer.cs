namespace AEIS
{
    partial class MCQMarkingSchema_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainMCQ = new System.Windows.Forms.Panel();
            this.breezeExtendedTheme1 = new Telerik.WinControls.Themes.BreezeExtendedTheme();
            this.pnlMCQControl = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlMCQControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMCQ
            // 
            this.pnlMainMCQ.AutoScroll = true;
            this.pnlMainMCQ.BackColor = System.Drawing.Color.White;
            this.pnlMainMCQ.Location = new System.Drawing.Point(0, 83);
            this.pnlMainMCQ.Name = "pnlMainMCQ";
            this.pnlMainMCQ.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMainMCQ.Size = new System.Drawing.Size(1009, 480);
            this.pnlMainMCQ.TabIndex = 8;
            // 
            // pnlMCQControl
            // 
            this.pnlMCQControl.BackgroundImage = global::AEIS.Properties.Resources.sidePan;
            this.pnlMCQControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMCQControl.Controls.Add(this.btnView);
            this.pnlMCQControl.Controls.Add(this.btnDelete);
            this.pnlMCQControl.Controls.Add(this.btnUpdate);
            this.pnlMCQControl.Controls.Add(this.btnAdd);
            this.pnlMCQControl.Location = new System.Drawing.Point(1, 0);
            this.pnlMCQControl.Name = "pnlMCQControl";
            this.pnlMCQControl.Size = new System.Drawing.Size(1007, 77);
            this.pnlMCQControl.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = global::AEIS.Properties.Resources.buttonBack;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = global::AEIS.Properties.Resources.edCan;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(289, 13);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(182, 48);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View MCQ Marking Scheme";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnView.MouseLeave += new System.EventHandler(this.btnView_MouseLeave);
            this.btnView.MouseHover += new System.EventHandler(this.btnView_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::AEIS.Properties.Resources.buttonBack;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::AEIS.Properties.Resources.edCan;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(758, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 48);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete MCQ Marking Scheme";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnMCQReport_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnMCQReport_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnMCQReport_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = global::AEIS.Properties.Resources.buttonBack;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::AEIS.Properties.Resources.edCan;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(527, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 48);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update MCQ Marking Scheme";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnMarkngMCQ_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnMarkngMCQ_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnMarkngMCQ_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::AEIS.Properties.Resources.buttonBack;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::AEIS.Properties.Resources.vieCan;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(56, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 48);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add MCQ Marking Scheme";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnMCQAnswerSheet_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnMCQAnswerSheet_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnMCQAnswerSheet_MouseHover);
            // 
            // MCQMarkingSchema_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMCQControl);
            this.Controls.Add(this.pnlMainMCQ);
            this.Name = "MCQMarkingSchema_Home";
            this.Size = new System.Drawing.Size(1011, 566);
            this.pnlMCQControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMCQControl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlMainMCQ;
        private Telerik.WinControls.Themes.BreezeExtendedTheme breezeExtendedTheme1;
        private System.Windows.Forms.Button btnView;



    }
}
