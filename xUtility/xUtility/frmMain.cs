using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xUtility
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            if (chkSameAsInputFolder.Checked == true)
                chkSameAsInputFolder_CheckedChanged(this, new EventArgs());
            else
                chkSameAsInputFolder.Checked = true; 
        }

        private void btnReplaceText_Click(object sender, EventArgs e)
        {
            panelButtonSide.Top = btnReplaceText.Top;
        }

        private void btnReplaceImages_Click(object sender, EventArgs e)
        {
            panelButtonSide.Top = btnReplaceImages.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReplaceTemplate_Click(object sender, EventArgs e)
        {
            panelButtonSide.Top = btnReplaceTemplate.Top;
        }

        private void btnBrowseInputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDlg = new FolderBrowserDialog()
            {
                ShowNewFolderButton = false
            };

            if(FolderDlg.ShowDialog()==DialogResult.OK)
            {
                txtInputFolder.Text = FolderDlg.SelectedPath;
            }
        }

        private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDlg = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true
            };

            if(FolderDlg.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = FolderDlg.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(chkDocx.Checked == false)
            {
                MessageBox.Show("Please select at least one file type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtInputFolder.Text))
            {
                MessageBox.Show("Invalid Input Folder : " + txtInputFolder.Text, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(chkSameAsInputFolder.Checked == false && !Directory.Exists(txtOutputFolder.Text))
            {
                MessageBox.Show("Invalid Output Folder : " + txtOutputFolder.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtFindWhat.Text == "")
            {
                MessageBox.Show("Empty Find Text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReplaceTextOptions replaceTextOptions = new ReplaceTextOptions
            {
                docx = chkDocx.Checked,
                xlsx = chkXlsx.Checked,
                pptx = chkPptx.Checked,
                txt = chkTxt.Checked,
                html = chkHtml.Checked,

                IncludeSubdirectories = chkIncludeSubdirectories.Checked,
                SameAsInputFolder = chkSameAsInputFolder.Checked,

                InputFolder = txtInputFolder.Text,
                OutputFolder = txtOutputFolder.Text,

                FindWhat = txtFindWhat.Text,
                ReplaceWith = txtReplaceWith.Text
            };

            ReplaceText replaceText = new ReplaceText(replaceTextOptions);

            try
            {
                replaceText.Run();
                MessageBox.Show("Operation is Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSameAsInputFolder_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSameAsInputFolder.Checked == true)
            {
                txtOutputFolder.Enabled = false;
                btnBrowseOutputFolder.Enabled = false;
            }
            else
            {
                txtOutputFolder.Enabled = true;
                btnBrowseOutputFolder.Enabled = true;
            }
        }
    }
}
