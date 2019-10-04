using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xUtility
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
            if(chkDocx.Checked==false)
            {
                MessageBox.Show("Please select at least one file type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtInputFolder.Text))
            {
                MessageBox.Show("Invalid Input Folder : " + txtInputFolder.Text, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(chkSameAsInputFolder.Checked==false && !Directory.Exists(txtOutputFolder.Text))
            {
                MessageBox.Show("Invalid Output Folder : " + txtOutputFolder.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IEnumerable<string> Files = Directory.EnumerateFiles(txtInputFolder.Text, "*.docx", SearchOption.AllDirectories);

                foreach (string MyFile in Files)
                {
                    using (WordprocessingDocument wdDoc = WordprocessingDocument.Open(FilePath, true))
                    {
                        string MyText;

                        using (StreamReader sr = new StreamReader(wdDoc.MainDocumentPart.GetStream()))
                        {
                            MyText = sr.ReadToEnd();
                        }

                        Regex Rx = new Regex("CT5/PHD");
                        MyText = Rx.Replace(MyText, "CPHD");

                        using (StreamWriter sw = new StreamWriter(wdDoc.MainDocumentPart.GetStream(FileMode.Create)))
                        {
                            sw.Write(MyText);
                        }
                    }

                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
