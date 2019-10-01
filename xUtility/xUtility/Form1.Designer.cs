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
            this.PanelButtonSide = new System.Windows.Forms.Panel();
            this.btnReplaceText = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.PanelButtonSide);
            this.panel1.Controls.Add(this.btnReplaceText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 339);
            this.panel1.TabIndex = 0;
            // 
            // PanelButtonSide
            // 
            this.PanelButtonSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.PanelButtonSide.Location = new System.Drawing.Point(134, 114);
            this.PanelButtonSide.Name = "PanelButtonSide";
            this.PanelButtonSide.Size = new System.Drawing.Size(6, 45);
            this.PanelButtonSide.TabIndex = 1;
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
            this.btnReplaceText.Location = new System.Drawing.Point(0, 114);
            this.btnReplaceText.Name = "btnReplaceText";
            this.btnReplaceText.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnReplaceText.Size = new System.Drawing.Size(140, 45);
            this.btnReplaceText.TabIndex = 1;
            this.btnReplaceText.Text = " Replace Text";
            this.btnReplaceText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReplaceText.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 69);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "xUtility";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 339);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xUtility";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReplaceText;
        private System.Windows.Forms.Panel PanelButtonSide;
    }
}

