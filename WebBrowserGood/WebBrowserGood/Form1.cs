using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserGood
{
    public partial class Main : Form
    {

        private string emptyOrNull = "You must first input a valid link!";
        public string homepage = "http://google.com";

        private void NavigateToPage()
        {
            button1.Enabled = false;
            txtUrl.Enabled = false;
            webBrowser.Navigate(txtUrl.Text);
        }

        private void NavigateToHomepage()
        {
            button1.Enabled = false;
            txtUrl.Enabled = false;
            webBrowser.Navigate(homepage);
        }

        public Main()
        {
            InitializeComponent();
            webBrowser.Navigate(homepage);            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Nadpher. ");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                NavigateToPage();
            }
            else
            {
                txtStatus.ForeColor = Color.Red;
                txtStatus.Text = emptyOrNull;
            }
            
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(txtUrl.Text))
                {
                    NavigateToPage();
                }
                else
                {
                    txtStatus.ForeColor = Color.Red;
                    txtStatus.Text = emptyOrNull;                    
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigateToHomepage();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            txtUrl.Enabled = true;
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form2 = new Settings())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    homepage = form2.textHomepage;
                }
            }
        }
    }
}
