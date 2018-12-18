using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string videoPath;
        private string videoName;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 File|*.mp4" };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoName = openFileDialog.SafeFileName;
            }

            textBox1.Text = videoPath;            

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                axWindowsMediaPlayer1.URL = "" + textBox1.Text;
                labelStatus.Text = videoName;
            }
            else
            {
                MessageBox.Show("You must first input a valid video path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    axWindowsMediaPlayer1.URL = "" + textBox1.Text;
                }
                else
                {
                    MessageBox.Show("You must first input a valid video path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
