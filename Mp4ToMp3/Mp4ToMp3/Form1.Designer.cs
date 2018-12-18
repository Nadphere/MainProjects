namespace Mp4ToMp3
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pathVideo = new System.Windows.Forms.TextBox();
            this.pathAudio = new System.Windows.Forms.TextBox();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Video to convert:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Directory to save to:";
            // 
            // pathVideo
            // 
            this.pathVideo.Location = new System.Drawing.Point(15, 69);
            this.pathVideo.Name = "pathVideo";
            this.pathVideo.Size = new System.Drawing.Size(186, 20);
            this.pathVideo.TabIndex = 2;
            this.pathVideo.TextChanged += new System.EventHandler(this.pathVideo_TextChanged);
            // 
            // pathAudio
            // 
            this.pathAudio.Location = new System.Drawing.Point(15, 149);
            this.pathAudio.Name = "pathAudio";
            this.pathAudio.Size = new System.Drawing.Size(186, 20);
            this.pathAudio.TabIndex = 3;
            this.pathAudio.TextChanged += new System.EventHandler(this.pathAudio_TextChanged);
            // 
            // buttonVideo
            // 
            this.buttonVideo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideo.Location = new System.Drawing.Point(207, 64);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(109, 28);
            this.buttonVideo.TabIndex = 4;
            this.buttonVideo.Text = "Open Video..";
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFolder.Location = new System.Drawing.Point(208, 145);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(108, 27);
            this.buttonFolder.TabIndex = 5;
            this.buttonFolder.Text = "Open Folder..";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(15, 190);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(301, 27);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(328, 234);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.pathAudio);
            this.Controls.Add(this.pathVideo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pathVideo;
        private System.Windows.Forms.TextBox pathAudio;
        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonConvert;
    }
}

