namespace KriptografskiUredajiSaveznika
{
    partial class Main
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSigaba = new System.Windows.Forms.Button();
            this.buttonTypex = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::KriptografskiUredajiSaveznika.Properties.Resources.ccmV2;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.buttonInfo);
            this.panelMain.Controls.Add(this.buttonSigaba);
            this.panelMain.Controls.Add(this.buttonTypex);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(757, 530);
            this.panelMain.TabIndex = 0;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonInfo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(322, 103);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(101, 68);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSigaba
            // 
            this.buttonSigaba.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSigaba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSigaba.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSigaba.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSigaba.Location = new System.Drawing.Point(230, 361);
            this.buttonSigaba.Name = "buttonSigaba";
            this.buttonSigaba.Size = new System.Drawing.Size(285, 68);
            this.buttonSigaba.TabIndex = 1;
            this.buttonSigaba.Text = "Sigaba";
            this.buttonSigaba.UseVisualStyleBackColor = false;
            this.buttonSigaba.Click += new System.EventHandler(this.buttonSigaba_Click);
            // 
            // buttonTypex
            // 
            this.buttonTypex.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTypex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTypex.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTypex.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTypex.Location = new System.Drawing.Point(230, 225);
            this.buttonTypex.Name = "buttonTypex";
            this.buttonTypex.Size = new System.Drawing.Size(285, 68);
            this.buttonTypex.TabIndex = 0;
            this.buttonTypex.Text = "Typex";
            this.buttonTypex.UseVisualStyleBackColor = false;
            this.buttonTypex.Click += new System.EventHandler(this.buttonTypex_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 530);
            this.Controls.Add(this.panelMain);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kriptografski uređaji saveznika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSigaba;
        private System.Windows.Forms.Button buttonTypex;
        private System.Windows.Forms.Button buttonInfo;
    }
}

