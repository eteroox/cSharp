namespace KriptografskiUredajiSaveznika
{
    partial class SigabaInfo
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
            this.labelPravila = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPravila
            // 
            this.labelPravila.AutoSize = true;
            this.labelPravila.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPravila.Location = new System.Drawing.Point(12, 9);
            this.labelPravila.Name = "labelPravila";
            this.labelPravila.Size = new System.Drawing.Size(0, 25);
            this.labelPravila.TabIndex = 1;
            // 
            // SigabaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 510);
            this.Controls.Add(this.labelPravila);
            this.MaximumSize = new System.Drawing.Size(672, 549);
            this.MinimumSize = new System.Drawing.Size(672, 549);
            this.Name = "SigabaInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigabaInfo";
            this.Load += new System.EventHandler(this.SigabaInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPravila;
    }
}