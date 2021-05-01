
namespace youtubeDownlode
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.buttonPlayList = new System.Windows.Forms.Button();
            this.radioMp3 = new System.Windows.Forms.RadioButton();
            this.radioMp4 = new System.Windows.Forms.RadioButton();
            this.buttonPaht = new System.Windows.Forms.Button();
            this.labelPAHT = new System.Windows.Forms.Label();
            this.progressBarDone = new System.Windows.Forms.ProgressBar();
            this.listBoxVideo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(35, 12);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(487, 20);
            this.textBoxUrl.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(11, 15);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "ID";
            // 
            // buttonVideo
            // 
            this.buttonVideo.Location = new System.Drawing.Point(35, 38);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(75, 23);
            this.buttonVideo.TabIndex = 2;
            this.buttonVideo.Text = "Video";
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // buttonPlayList
            // 
            this.buttonPlayList.Location = new System.Drawing.Point(116, 38);
            this.buttonPlayList.Name = "buttonPlayList";
            this.buttonPlayList.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayList.TabIndex = 3;
            this.buttonPlayList.Text = "PlayList";
            this.buttonPlayList.UseVisualStyleBackColor = true;
            this.buttonPlayList.Click += new System.EventHandler(this.buttonPlayList_Click);
            // 
            // radioMp3
            // 
            this.radioMp3.AutoSize = true;
            this.radioMp3.Checked = true;
            this.radioMp3.Location = new System.Drawing.Point(241, 38);
            this.radioMp3.Name = "radioMp3";
            this.radioMp3.Size = new System.Drawing.Size(47, 17);
            this.radioMp3.TabIndex = 4;
            this.radioMp3.TabStop = true;
            this.radioMp3.Text = "MP3";
            this.radioMp3.UseVisualStyleBackColor = true;
            // 
            // radioMp4
            // 
            this.radioMp4.AutoSize = true;
            this.radioMp4.Location = new System.Drawing.Point(290, 37);
            this.radioMp4.Name = "radioMp4";
            this.radioMp4.Size = new System.Drawing.Size(47, 17);
            this.radioMp4.TabIndex = 5;
            this.radioMp4.Text = "MP4";
            this.radioMp4.UseVisualStyleBackColor = true;
            // 
            // buttonPaht
            // 
            this.buttonPaht.Location = new System.Drawing.Point(12, 77);
            this.buttonPaht.Name = "buttonPaht";
            this.buttonPaht.Size = new System.Drawing.Size(75, 23);
            this.buttonPaht.TabIndex = 6;
            this.buttonPaht.Text = "Paht";
            this.buttonPaht.UseVisualStyleBackColor = true;
            this.buttonPaht.Click += new System.EventHandler(this.buttonPaht_Click);
            // 
            // labelPAHT
            // 
            this.labelPAHT.AutoSize = true;
            this.labelPAHT.Location = new System.Drawing.Point(93, 83);
            this.labelPAHT.Name = "labelPAHT";
            this.labelPAHT.Size = new System.Drawing.Size(0, 13);
            this.labelPAHT.TabIndex = 7;
            // 
            // progressBarDone
            // 
            this.progressBarDone.Location = new System.Drawing.Point(2, 110);
            this.progressBarDone.Name = "progressBarDone";
            this.progressBarDone.Size = new System.Drawing.Size(587, 23);
            this.progressBarDone.Step = 1;
            this.progressBarDone.TabIndex = 8;
            // 
            // listBoxVideo
            // 
            this.listBoxVideo.FormattingEnabled = true;
            this.listBoxVideo.Location = new System.Drawing.Point(8, 139);
            this.listBoxVideo.Name = "listBoxVideo";
            this.listBoxVideo.Size = new System.Drawing.Size(575, 134);
            this.listBoxVideo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 279);
            this.Controls.Add(this.listBoxVideo);
            this.Controls.Add(this.progressBarDone);
            this.Controls.Add(this.labelPAHT);
            this.Controls.Add(this.buttonPaht);
            this.Controls.Add(this.radioMp4);
            this.Controls.Add(this.radioMp3);
            this.Controls.Add(this.buttonPlayList);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.textBoxUrl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(605, 318);
            this.MinimumSize = new System.Drawing.Size(605, 318);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.Button buttonPlayList;
        private System.Windows.Forms.RadioButton radioMp3;
        private System.Windows.Forms.RadioButton radioMp4;
        private System.Windows.Forms.Button buttonPaht;
        private System.Windows.Forms.Label labelPAHT;
        private System.Windows.Forms.ProgressBar progressBarDone;
        private System.Windows.Forms.ListBox listBoxVideo;
    }
}

