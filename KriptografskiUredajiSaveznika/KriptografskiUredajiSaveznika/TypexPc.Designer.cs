namespace KriptografskiUredajiSaveznika
{
    partial class TypexPc
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
            this.timerTypex = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxSavText = new System.Windows.Forms.RichTextBox();
            this.buttonHowTo = new System.Windows.Forms.Button();
            this.textBoxPrviBroj = new System.Windows.Forms.TextBox();
            this.textBoxDrugiBroj = new System.Windows.Forms.TextBox();
            this.textBoxSifrirano = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonZnakovi = new System.Windows.Forms.Button();
            this.buttonScripta = new System.Windows.Forms.Button();
            this.buttonSifre = new System.Windows.Forms.Button();
            this.pictureBoxSlider = new System.Windows.Forms.PictureBox();
            this.textBoxTreciBroj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTypex
            // 
            this.timerTypex.Enabled = true;
            this.timerTypex.Interval = 3000;
            this.timerTypex.Tick += new System.EventHandler(this.timerTypex_Tick);
            // 
            // richTextBoxSavText
            // 
            this.richTextBoxSavText.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSavText.Location = new System.Drawing.Point(12, 263);
            this.richTextBoxSavText.Name = "richTextBoxSavText";
            this.richTextBoxSavText.ReadOnly = true;
            this.richTextBoxSavText.Size = new System.Drawing.Size(667, 271);
            this.richTextBoxSavText.TabIndex = 1;
            this.richTextBoxSavText.Text = "";
            // 
            // buttonHowTo
            // 
            this.buttonHowTo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHowTo.Location = new System.Drawing.Point(635, 12);
            this.buttonHowTo.Name = "buttonHowTo";
            this.buttonHowTo.Size = new System.Drawing.Size(44, 41);
            this.buttonHowTo.TabIndex = 2;
            this.buttonHowTo.Text = "?";
            this.buttonHowTo.UseVisualStyleBackColor = true;
            this.buttonHowTo.Click += new System.EventHandler(this.buttonHowTo_Click);
            // 
            // textBoxPrviBroj
            // 
            this.textBoxPrviBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrviBroj.ForeColor = System.Drawing.Color.Red;
            this.textBoxPrviBroj.Location = new System.Drawing.Point(271, 545);
            this.textBoxPrviBroj.Name = "textBoxPrviBroj";
            this.textBoxPrviBroj.Size = new System.Drawing.Size(37, 31);
            this.textBoxPrviBroj.TabIndex = 3;
            // 
            // textBoxDrugiBroj
            // 
            this.textBoxDrugiBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrugiBroj.ForeColor = System.Drawing.Color.Red;
            this.textBoxDrugiBroj.Location = new System.Drawing.Point(330, 545);
            this.textBoxDrugiBroj.Name = "textBoxDrugiBroj";
            this.textBoxDrugiBroj.Size = new System.Drawing.Size(37, 31);
            this.textBoxDrugiBroj.TabIndex = 4;
            // 
            // textBoxSifrirano
            // 
            this.textBoxSifrirano.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSifrirano.Location = new System.Drawing.Point(12, 582);
            this.textBoxSifrirano.Name = "textBoxSifrirano";
            this.textBoxSifrirano.Size = new System.Drawing.Size(667, 29);
            this.textBoxSifrirano.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(271, 617);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(155, 56);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Potvrdi";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonZnakovi
            // 
            this.buttonZnakovi.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZnakovi.Location = new System.Drawing.Point(635, 59);
            this.buttonZnakovi.Name = "buttonZnakovi";
            this.buttonZnakovi.Size = new System.Drawing.Size(44, 41);
            this.buttonZnakovi.TabIndex = 7;
            this.buttonZnakovi.Text = "+";
            this.buttonZnakovi.UseVisualStyleBackColor = true;
            this.buttonZnakovi.Click += new System.EventHandler(this.buttonZnakovi_Click);
            // 
            // buttonScripta
            // 
            this.buttonScripta.BackgroundImage = global::KriptografskiUredajiSaveznika.Properties.Resources.papir;
            this.buttonScripta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonScripta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScripta.Location = new System.Drawing.Point(635, 153);
            this.buttonScripta.Name = "buttonScripta";
            this.buttonScripta.Size = new System.Drawing.Size(44, 41);
            this.buttonScripta.TabIndex = 9;
            this.buttonScripta.UseVisualStyleBackColor = true;
            this.buttonScripta.Click += new System.EventHandler(this.buttonScripta_Click);
            // 
            // buttonSifre
            // 
            this.buttonSifre.BackgroundImage = global::KriptografskiUredajiSaveznika.Properties.Resources.sifra;
            this.buttonSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSifre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSifre.Location = new System.Drawing.Point(635, 106);
            this.buttonSifre.Name = "buttonSifre";
            this.buttonSifre.Size = new System.Drawing.Size(44, 41);
            this.buttonSifre.TabIndex = 8;
            this.buttonSifre.UseVisualStyleBackColor = true;
            this.buttonSifre.Click += new System.EventHandler(this.buttonSifre_Click);
            // 
            // pictureBoxSlider
            // 
            this.pictureBoxSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSlider.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSlider.Name = "pictureBoxSlider";
            this.pictureBoxSlider.Size = new System.Drawing.Size(691, 228);
            this.pictureBoxSlider.TabIndex = 0;
            this.pictureBoxSlider.TabStop = false;
            // 
            // textBoxTreciBroj
            // 
            this.textBoxTreciBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTreciBroj.ForeColor = System.Drawing.Color.Red;
            this.textBoxTreciBroj.Location = new System.Drawing.Point(389, 545);
            this.textBoxTreciBroj.Name = "textBoxTreciBroj";
            this.textBoxTreciBroj.Size = new System.Drawing.Size(37, 31);
            this.textBoxTreciBroj.TabIndex = 10;
            // 
            // TypexPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(691, 678);
            this.Controls.Add(this.textBoxTreciBroj);
            this.Controls.Add(this.buttonScripta);
            this.Controls.Add(this.buttonSifre);
            this.Controls.Add(this.buttonZnakovi);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxSifrirano);
            this.Controls.Add(this.textBoxDrugiBroj);
            this.Controls.Add(this.textBoxPrviBroj);
            this.Controls.Add(this.buttonHowTo);
            this.Controls.Add(this.richTextBoxSavText);
            this.Controls.Add(this.pictureBoxSlider);
            this.MaximumSize = new System.Drawing.Size(707, 717);
            this.MinimumSize = new System.Drawing.Size(707, 717);
            this.Name = "TypexPc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypexPc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypexPc_FormClosed);
            this.Load += new System.EventHandler(this.TypexPc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSlider;
        private System.Windows.Forms.Timer timerTypex;
        private System.Windows.Forms.RichTextBox richTextBoxSavText;
        private System.Windows.Forms.Button buttonHowTo;
        private System.Windows.Forms.TextBox textBoxPrviBroj;
        private System.Windows.Forms.TextBox textBoxDrugiBroj;
        private System.Windows.Forms.TextBox textBoxSifrirano;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonZnakovi;
        private System.Windows.Forms.Button buttonSifre;
        private System.Windows.Forms.Button buttonScripta;
        private System.Windows.Forms.TextBox textBoxTreciBroj;
    }
}