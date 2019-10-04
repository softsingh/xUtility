namespace xUtility
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButtonSide = new System.Windows.Forms.Panel();
            this.btnReplaceImages = new System.Windows.Forms.Button();
            this.btnReplaceText = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseInputFolder = new System.Windows.Forms.Button();
            this.chkDocx = new System.Windows.Forms.CheckBox();
            this.chkXlsx = new System.Windows.Forms.CheckBox();
            this.chkPptx = new System.Windows.Forms.CheckBox();
            this.chkTxt = new System.Windows.Forms.CheckBox();
            this.chkHtml = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSameAsInputFolder = new System.Windows.Forms.CheckBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReplaceTemplate = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtFindWhat = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.panelButtonSide);
            this.panel1.Controls.Add(this.btnReplaceTemplate);
            this.panel1.Controls.Add(this.btnReplaceImages);
            this.panel1.Controls.Add(this.btnReplaceText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 448);
            this.panel1.TabIndex = 0;
            // 
            // panelButtonSide
            // 
            this.panelButtonSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtonSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.panelButtonSide.Location = new System.Drawing.Point(154, 101);
            this.panelButtonSide.Name = "panelButtonSide";
            this.panelButtonSide.Size = new System.Drawing.Size(6, 45);
            this.panelButtonSide.TabIndex = 1;
            // 
            // btnReplaceImages
            // 
            this.btnReplaceImages.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReplaceImages.FlatAppearance.BorderSize = 0;
            this.btnReplaceImages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnReplaceImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceImages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReplaceImages.Image = global::xUtility.Properties.Resources.Replace;
            this.btnReplaceImages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceImages.Location = new System.Drawing.Point(0, 152);
            this.btnReplaceImages.Name = "btnReplaceImages";
            this.btnReplaceImages.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnReplaceImages.Size = new System.Drawing.Size(160, 45);
            this.btnReplaceImages.TabIndex = 2;
            this.btnReplaceImages.Text = " Replace Images";
            this.btnReplaceImages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReplaceImages.UseVisualStyleBackColor = true;
            this.btnReplaceImages.Click += new System.EventHandler(this.btnReplaceImages_Click);
            // 
            // btnReplaceText
            // 
            this.btnReplaceText.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReplaceText.FlatAppearance.BorderSize = 0;
            this.btnReplaceText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnReplaceText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReplaceText.Image = global::xUtility.Properties.Resources.Replace;
            this.btnReplaceText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceText.Location = new System.Drawing.Point(0, 101);
            this.btnReplaceText.Name = "btnReplaceText";
            this.btnReplaceText.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnReplaceText.Size = new System.Drawing.Size(160, 45);
            this.btnReplaceText.TabIndex = 1;
            this.btnReplaceText.Text = " Replace Text";
            this.btnReplaceText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReplaceText.UseVisualStyleBackColor = true;
            this.btnReplaceText.Click += new System.EventHandler(this.btnReplaceText_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 69);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "xUtility";
            // 
            // txtInputFolder
            // 
            this.txtInputFolder.Location = new System.Drawing.Point(6, 19);
            this.txtInputFolder.Name = "txtInputFolder";
            this.txtInputFolder.Size = new System.Drawing.Size(388, 20);
            this.txtInputFolder.TabIndex = 1;
            // 
            // btnBrowseInputFolder
            // 
            this.btnBrowseInputFolder.Location = new System.Drawing.Point(400, 18);
            this.btnBrowseInputFolder.Name = "btnBrowseInputFolder";
            this.btnBrowseInputFolder.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseInputFolder.TabIndex = 3;
            this.btnBrowseInputFolder.Text = "---";
            this.btnBrowseInputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseInputFolder.Click += new System.EventHandler(this.btnBrowseInputFolder_Click);
            // 
            // chkDocx
            // 
            this.chkDocx.AutoSize = true;
            this.chkDocx.Checked = true;
            this.chkDocx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDocx.Location = new System.Drawing.Point(13, 19);
            this.chkDocx.Name = "chkDocx";
            this.chkDocx.Size = new System.Drawing.Size(52, 17);
            this.chkDocx.TabIndex = 4;
            this.chkDocx.Text = ".docx";
            this.chkDocx.UseVisualStyleBackColor = true;
            // 
            // chkXlsx
            // 
            this.chkXlsx.AutoSize = true;
            this.chkXlsx.Location = new System.Drawing.Point(71, 19);
            this.chkXlsx.Name = "chkXlsx";
            this.chkXlsx.Size = new System.Drawing.Size(46, 17);
            this.chkXlsx.TabIndex = 4;
            this.chkXlsx.Text = ".xlsx";
            this.chkXlsx.UseVisualStyleBackColor = true;
            // 
            // chkPptx
            // 
            this.chkPptx.AutoSize = true;
            this.chkPptx.Location = new System.Drawing.Point(123, 19);
            this.chkPptx.Name = "chkPptx";
            this.chkPptx.Size = new System.Drawing.Size(49, 17);
            this.chkPptx.TabIndex = 4;
            this.chkPptx.Text = ".pptx";
            this.chkPptx.UseVisualStyleBackColor = true;
            // 
            // chkTxt
            // 
            this.chkTxt.AutoSize = true;
            this.chkTxt.Location = new System.Drawing.Point(178, 19);
            this.chkTxt.Name = "chkTxt";
            this.chkTxt.Size = new System.Drawing.Size(40, 17);
            this.chkTxt.TabIndex = 4;
            this.chkTxt.Text = ".txt";
            this.chkTxt.UseVisualStyleBackColor = true;
            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Location = new System.Drawing.Point(224, 19);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new System.Drawing.Size(48, 17);
            this.chkHtml.TabIndex = 4;
            this.chkHtml.Text = ".html";
            this.chkHtml.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDocx);
            this.groupBox1.Controls.Add(this.chkHtml);
            this.groupBox1.Controls.Add(this.chkXlsx);
            this.groupBox1.Controls.Add(this.chkTxt);
            this.groupBox1.Controls.Add(this.chkPptx);
            this.groupBox1.Location = new System.Drawing.Point(272, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Filter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInputFolder);
            this.groupBox2.Controls.Add(this.btnBrowseInputFolder);
            this.groupBox2.Location = new System.Drawing.Point(194, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Folder";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSameAsInputFolder);
            this.groupBox3.Controls.Add(this.txtOutputFolder);
            this.groupBox3.Controls.Add(this.btnBrowseOutputFolder);
            this.groupBox3.Location = new System.Drawing.Point(194, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 79);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Folder";
            // 
            // chkSameAsInputFolder
            // 
            this.chkSameAsInputFolder.AutoSize = true;
            this.chkSameAsInputFolder.Location = new System.Drawing.Point(149, 19);
            this.chkSameAsInputFolder.Name = "chkSameAsInputFolder";
            this.chkSameAsInputFolder.Size = new System.Drawing.Size(126, 17);
            this.chkSameAsInputFolder.TabIndex = 5;
            this.chkSameAsInputFolder.Text = "Same as Input Folder";
            this.chkSameAsInputFolder.UseVisualStyleBackColor = true;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(6, 45);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(388, 20);
            this.txtOutputFolder.TabIndex = 1;
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.Location = new System.Drawing.Point(400, 44);
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseOutputFolder.TabIndex = 3;
            this.btnBrowseOutputFolder.Text = "---";
            this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Location = new System.Drawing.Point(194, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 45);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(429, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(484, 411);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(565, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReplaceTemplate
            // 
            this.btnReplaceTemplate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReplaceTemplate.FlatAppearance.BorderSize = 0;
            this.btnReplaceTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnReplaceTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceTemplate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReplaceTemplate.Image = global::xUtility.Properties.Resources.Replace;
            this.btnReplaceTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceTemplate.Location = new System.Drawing.Point(0, 203);
            this.btnReplaceTemplate.Name = "btnReplaceTemplate";
            this.btnReplaceTemplate.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnReplaceTemplate.Size = new System.Drawing.Size(160, 45);
            this.btnReplaceTemplate.TabIndex = 3;
            this.btnReplaceTemplate.Text = " Replace Template";
            this.btnReplaceTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReplaceTemplate.UseVisualStyleBackColor = true;
            this.btnReplaceTemplate.Click += new System.EventHandler(this.btnReplaceTemplate_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtFindWhat);
            this.groupBox5.Location = new System.Drawing.Point(194, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 55);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Find What";
            // 
            // txtFindWhat
            // 
            this.txtFindWhat.Location = new System.Drawing.Point(6, 19);
            this.txtFindWhat.Name = "txtFindWhat";
            this.txtFindWhat.Size = new System.Drawing.Size(429, 20);
            this.txtFindWhat.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtReplaceWith);
            this.groupBox6.Location = new System.Drawing.Point(195, 270);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(446, 55);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Replace With";
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(6, 19);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(429, 20);
            this.txtReplaceWith.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 448);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xUtility";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReplaceText;
        private System.Windows.Forms.Panel panelButtonSide;
        private System.Windows.Forms.Button btnReplaceImages;
        private System.Windows.Forms.TextBox txtInputFolder;
        private System.Windows.Forms.Button btnBrowseInputFolder;
        private System.Windows.Forms.CheckBox chkDocx;
        private System.Windows.Forms.CheckBox chkXlsx;
        private System.Windows.Forms.CheckBox chkPptx;
        private System.Windows.Forms.CheckBox chkTxt;
        private System.Windows.Forms.CheckBox chkHtml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSameAsInputFolder;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnBrowseOutputFolder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReplaceTemplate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFindWhat;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtReplaceWith;
    }
}

