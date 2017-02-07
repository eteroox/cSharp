namespace KriptografskiUredajiSaveznika
{
    partial class SigabaSkripta
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
            this.labelSkripta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSkripta
            // 
            this.labelSkripta.AutoSize = true;
            this.labelSkripta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkripta.Location = new System.Drawing.Point(12, 9);
            this.labelSkripta.Name = "labelSkripta";
            this.labelSkripta.Size = new System.Drawing.Size(0, 25);
            this.labelSkripta.TabIndex = 1;
            // 
            // SigabaSkripta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 514);
            this.Controls.Add(this.labelSkripta);
            this.MaximumSize = new System.Drawing.Size(571, 553);
            this.MinimumSize = new System.Drawing.Size(571, 553);
            this.Name = "SigabaSkripta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigabaSkripta";
            this.Load += new System.EventHandler(this.SigabaSkripta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSkripta;
    }
}