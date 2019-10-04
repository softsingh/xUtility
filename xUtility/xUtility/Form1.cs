using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
