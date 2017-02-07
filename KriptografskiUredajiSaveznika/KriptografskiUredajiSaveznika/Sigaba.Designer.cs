namespace KriptografskiUredajiSaveznika
{
    partial class Sigaba
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonScripta = new System.Windows.Forms.Button();
            this.buttonSifre = new System.Windows.Forms.Button();
            this.buttonHowTo = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxSifrirano = new System.Windows.Forms.TextBox();
            this.richTextBoxSavText = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSlider = new System.Windows.Forms.PictureBox();
            this.timerSigaba = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonScripta);
            this.panel1.Controls.Add(this.buttonSifre);
            this.panel1.Controls.Add(this.buttonHowTo);
            this.panel1.Controls.Add(this.buttonSubmit);
            this.panel1.Controls.Add(this.textBoxSifrirano);
            this.panel1.Controls.Add(this.richTextBoxSavText);
            this.panel1.Controls.Add(this.pictureBoxSlider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 678);
            this.panel1.TabIndex = 0;
            // 
            // buttonScripta
            // 
            this.buttonScripta.BackgroundImage = global::KriptografskiUredajiSaveznika.Properties.Resources.papir;
            this.buttonScripta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonScripta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScripta.Location = new System.Drawing.Point(635, 106);
            this.buttonScripta.Name = "buttonScripta";
            this.buttonScripta.Size = new System.Drawing.Size(44, 41);
            this.buttonScripta.TabIndex = 12;
            this.buttonScripta.UseVisualStyleBackColor = true;
            this.buttonScripta.Click += new System.EventHandler(this.buttonScripta_Click);
            // 
            // buttonSifre
            // 
            this.buttonSifre.BackgroundImage = global::KriptografskiUredajiSaveznika.Properties.Resources.sifra;
            this.buttonSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSifre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSifre.Location = new System.Drawing.Point(635, 59);
            this.buttonSifre.Name = "buttonSifre";
            this.buttonSifre.Size = new System.Drawing.Size(44, 41);
            this.buttonSifre.TabIndex = 11;
            this.buttonSifre.UseVisualStyleBackColor = true;
            this.buttonSifre.Click += new System.EventHandler(this.buttonSifre_Click);
            // 
            // buttonHowTo
            // 
            this.buttonHowTo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHowTo.Location = new System.Drawing.Point(635, 12);
            this.buttonHowTo.Name = "buttonHowTo";
            this.buttonHowTo.Size = new System.Drawing.Size(44, 41);
            this.buttonHowTo.TabIndex = 10;
            this.buttonHowTo.Text = "?";
            this.buttonHowTo.UseVisualStyleBackColor = true;
            this.buttonHowTo.Click += new System.EventHandler(this.buttonHowTo_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(267, 614);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(155, 56);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Potvrdi";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxSifrirano
            // 
            this.textBoxSifrirano.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSifrirano.Location = new System.Drawing.Point(12, 557);
            this.textBoxSifrirano.Name = "textBoxSifrirano";
            this.textBoxSifrirano.Size = new System.Drawing.Size(667, 29);
            this.textBoxSifrirano.TabIndex = 8;
            // 
            // richTextBoxSavText
            // 
            this.richTextBoxSavText.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSavText.Location = new System.Drawing.Point(12, 287);
            this.richTextBoxSavText.Name = "richTextBoxSavText";
            this.richTextBoxSavText.ReadOnly = true;
            this.richTextBoxSavText.Size = new System.Drawing.Size(667, 254);
            this.richTextBoxSavText.TabIndex = 7;
            this.richTextBoxSavText.Text = "";
            // 
            // pictureBoxSlider
            // 
            this.pictureBoxSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSlider.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSlider.Name = "pictureBoxSlider";
            this.pictureBoxSlider.Size = new System.Drawing.Size(691, 277);
            this.pictureBoxSlider.TabIndex = 1;
            this.pictureBoxSlider.TabStop = false;
            // 
            // timerSigaba
            // 
            this.timerSigaba.Enabled = true;
            this.timerSigaba.Interval = 3000;
            this.timerSigaba.Tick += new System.EventHandler(this.timerSigaba_Tick);
            // 
            // Sigaba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 678);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(707, 717);
            this.MinimumSize = new System.Drawing.Size(707, 717);
            this.Name = "Sigaba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sigaba";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sigaba_FormClosed);
            this.Load += new System.EventHandler(this.Sigaba_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerSigaba;
        private System.Windows.Forms.PictureBox pictureBoxSlider;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxSifrirano;
        private System.Windows.Forms.RichTextBox richTextBoxSavText;
        private System.Windows.Forms.Button buttonSifre;
        private System.Windows.Forms.Button buttonHowTo;
        private System.Windows.Forms.Button buttonScripta;
    }
}