using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using static xUtility.Utils;

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

            if(Directory.Exists(txtInputFolder.Text))
            {
                FolderDlg.SelectedPath = txtInputFolder.Text;
            }

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

            if (Directory.Exists(txtOutputFolder.Text))
            {
                FolderDlg.SelectedPath = txtOutputFolder.Text;
            }

            if (FolderDlg.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = FolderDlg.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ErrorFlag = false;

            if (chkDocx.Checked == false)
            {
                MessageBox.Show("Please select at least one file type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtInputFolder.Text))
            {
                MessageBox.Show("Invalid Input Folder : " + txtInputFolder.Text, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Log.CreateEntry();
            Log.CreateEntry("#", RepeatTextCount: 100);
            Log.CreateEntry("ReplaceText Operation Started");
            Log.CreateEntry("#", RepeatTextCount: 100);
            Log.CreateEntry();

            if (chkSameAsInputFolder.Checked == false)
            {
                if(txtOutputFolder.Text=="")
                {
                    MessageBox.Show("Output Folder Path is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CopyFilesOptions copyFilesOptions = new CopyFilesOptions(replaceTextOptions);
                CopyFiles copyFiles = new CopyFiles();

                //try
                //{
                    copyFiles.Run(copyFilesOptions);
                //}
                //catch (Exception Ex)
                //{
                //    ErrorFlag = true;
                //    Log.CreateEntry("-", RepeatTextCount: 100);
                //    Log.CreateEntry("CopyFiles: " + Ex.Message, "ERR");
                //    Log.CreateEntry("-", RepeatTextCount: 100);
                //}

                if (ErrorFlag)
                {
                    MessageBox.Show("Error Occured in Copying Files. View Log File for more Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                replaceTextOptions.InputFolder = replaceTextOptions.OutputFolder;
            }

            ReplaceText replaceText = new ReplaceText(replaceTextOptions);

            //try
            //{
                replaceText.Run();
            //}
            //catch(Exception Ex)
            //{
            //    ErrorFlag = true;

            //    Log.CreateEntry("-", RepeatTextCount: 100);
            //    Log.CreateEntry("Error: " + Ex.Message, "ERR");
            //    Log.CreateEntry("-", RepeatTextCount: 100);

            //    MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (ErrorFlag)
            {
                Log.CreateEntry();
                Log.CreateEntry("#", RepeatTextCount: 100);
                Log.CreateEntry("Replace Text Operation Finished with Errors");
                Log.CreateEntry("#", RepeatTextCount: 100);
                Log.CreateEntry();

                MessageBox.Show("Replace Text Operation Finished with Errors. View Log File for more Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Log.CreateEntry();
                Log.CreateEntry("#", RepeatTextCount: 100);
                Log.CreateEntry("Replace Text Operation is Complete");
                Log.CreateEntry("#", RepeatTextCount: 100);
                Log.CreateEntry();

                MessageBox.Show("Replace Text Operation is Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkSameAsInputFolder_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSameAsInputFolder.Checked == true)
            {
                txtOutputFolder.Text = txtInputFolder.Text;
                txtOutputFolder.Enabled = false;
                btnBrowseOutputFolder.Enabled = false;
            }
            else
            {
                txtOutputFolder.Enabled = true;
                btnBrowseOutputFolder.Enabled = true;
            }
        }

        private void txtInputFolder_TextChanged(object sender, EventArgs e)
        {
            if(chkSameAsInputFolder.Checked==true)
            {
                txtOutputFolder.Text = txtInputFolder.Text;
            }
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Log.LOG_FOLDER);
        }
    }
}
