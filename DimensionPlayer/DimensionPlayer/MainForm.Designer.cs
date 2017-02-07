namespace DimensionPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonYoutube = new System.Windows.Forms.Button();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.buttonGlazba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInfo.Location = new System.Drawing.Point(259, 501);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 42);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonYoutube
            // 
            this.buttonYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYoutube.BackgroundImage = global::DimensionPlayer.Properties.Resources.favicon;
            this.buttonYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonYoutube.Location = new System.Drawing.Point(195, 379);
            this.buttonYoutube.Name = "buttonYoutube";
            this.buttonYoutube.Size = new System.Drawing.Size(215, 85);
            this.buttonYoutube.TabIndex = 2;
            this.buttonYoutube.UseVisualStyleBackColor = true;
            this.buttonYoutube.Click += new System.EventHandler(this.buttonYoutube_Click);
            // 
            // buttonVideo
            // 
            this.buttonVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVideo.BackgroundImage = global::DimensionPlayer.Properties.Resources.video;
            this.buttonVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonVideo.Image = global::DimensionPlayer.Properties.Resources.video;
            this.buttonVideo.Location = new System.Drawing.Point(195, 236);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(215, 85);
            this.buttonVideo.TabIndex = 1;
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // buttonGlazba
            // 
            this.buttonGlazba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGlazba.BackgroundImage = global::DimensionPlayer.Properties.Resources.note3;
            this.buttonGlazba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGlazba.Image = global::DimensionPlayer.Properties.Resources.note3;
            this.buttonGlazba.Location = new System.Drawing.Point(195, 92);
            this.buttonGlazba.Name = "buttonGlazba";
            this.buttonGlazba.Size = new System.Drawing.Size(215, 85);
            this.buttonGlazba.TabIndex = 0;
            this.buttonGlazba.UseVisualStyleBackColor = true;
            this.buttonGlazba.Click += new System.EventHandler(this.buttonGlazba_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(638, 562);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonYoutube);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.buttonGlazba);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(654, 600);
            this.MinimumSize = new System.Drawing.Size(654, 600);
            this.Name = "MainForm";
            this.Text = "DimensionPlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGlazba;
        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.Button buttonYoutube;
        private System.Windows.Forms.Button buttonInfo;
    }
}

