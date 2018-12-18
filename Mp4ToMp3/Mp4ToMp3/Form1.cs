using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp4ToMp3
{
    public partial class Form1 : Form
    {

        string videoPath, videoName, musicPath, musicName;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                musicPath = folderBrowserDialog.SelectedPath;
                musicName = videoName.Substring(0, videoName.Length - 4);
                musicPath += ("\\" + musicName + ".mp3");
            }

            pathAudio.Text = musicPath;

        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 File|*.mp4" };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoName = openFileDialog.SafeFileName;
            }

            pathVideo.Text = videoPath;

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if ((pathAudio.Text == string.Empty && pathVideo.Text == string.Empty) || pathAudio.Text == string.Empty || pathVideo.Text == string.Empty)
            {
                MessageBox.Show("You have to select both options!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var convert = new NReco.VideoConverter.FFMpegConverter();
                convert.ConvertMedia(pathVideo.Text.Trim(), pathAudio.Text.Trim(), "mp3");
                MessageBox.Show("Done.", "Convert", MessageBoxButtons.OK);
            }
        }

        private void pathVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pathAudio_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
