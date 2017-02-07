namespace TextPad1
{
    partial class replaceForm
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
            this.replaceFindLabel = new System.Windows.Forms.Label();
            this.replaceFindWhatTextBox = new System.Windows.Forms.TextBox();
            this.replaceFindNextButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.replaceCancelButton = new System.Windows.Forms.Button();
            this.replaceWithLabel = new System.Windows.Forms.Label();
            this.replaceWithTextBox = new System.Windows.Forms.TextBox();
            this.replaceMatchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // replaceFindLabel
            // 
            this.replaceFindLabel.AutoSize = true;
            this.replaceFindLabel.Location = new System.Drawing.Point(3, 13);
            this.replaceFindLabel.Name = "replaceFindLabel";
            this.replaceFindLabel.Size = new System.Drawing.Size(56, 13);
            this.replaceFindLabel.TabIndex = 1;
            this.replaceFindLabel.Text = "Find what:";
            // 
            // replaceFindWhatTextBox
            // 
            this.replaceFindWhatTextBox.Location = new System.Drawing.Point(77, 10);
            this.replaceFindWhatTextBox.Name = "replaceFindWhatTextBox";
            this.replaceFindWhatTextBox.Size = new System.Drawing.Size(178, 20);
            this.replaceFindWhatTextBox.TabIndex = 2;
            this.replaceFindWhatTextBox.TextChanged += new System.EventHandler(this.replaceFindWhatTextBox_TextChanged);
            // 
            // replaceFindNextButton
            // 
            this.replaceFindNextButton.Enabled = false;
            this.replaceFindNextButton.Location = new System.Drawing.Point(261, 7);
            this.replaceFindNextButton.Name = "replaceFindNextButton";
            this.replaceFindNextButton.Size = new System.Drawing.Size(74, 23);
            this.replaceFindNextButton.TabIndex = 5;
            this.replaceFindNextButton.Text = "Find Next";
            this.replaceFindNextButton.UseVisualStyleBackColor = true;
            this.replaceFindNextButton.Click += new System.EventHandler(this.replaceFindNextButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Enabled = false;
            this.replaceButton.Location = new System.Drawing.Point(261, 36);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(74, 23);
            this.replaceButton.TabIndex = 6;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Enabled = false;
            this.replaceAllButton.Location = new System.Drawing.Point(261, 65);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(74, 23);
            this.replaceAllButton.TabIndex = 7;
            this.replaceAllButton.Text = "Replace All";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            this.replaceAllButton.Click += new System.EventHandler(this.replaceAllButton_Click);
            // 
            // replaceCancelButton
            // 
            this.replaceCancelButton.Location = new System.Drawing.Point(261, 94);
            this.replaceCancelButton.Name = "replaceCancelButton";
            this.replaceCancelButton.Size = new System.Drawing.Size(74, 23);
            this.replaceCancelButton.TabIndex = 8;
            this.replaceCancelButton.Text = "Cancel";
            this.replaceCancelButton.UseVisualStyleBackColor = true;
            this.replaceCancelButton.Click += new System.EventHandler(this.replaceCancelButton_Click);
            // 
            // replaceWithLabel
            // 
            this.replaceWithLabel.AutoSize = true;
            this.replaceWithLabel.Location = new System.Drawing.Point(3, 42);
            this.replaceWithLabel.Name = "replaceWithLabel";
            this.replaceWithLabel.Size = new System.Drawing.Size(72, 13);
            this.replaceWithLabel.TabIndex = 9;
            this.replaceWithLabel.Text = "Replace with:";
            // 
            // replaceWithTextBox
            // 
            this.replaceWithTextBox.Location = new System.Drawing.Point(77, 39);
            this.replaceWithTextBox.Name = "replaceWithTextBox";
            this.replaceWithTextBox.Size = new System.Drawing.Size(178, 20);
            this.replaceWithTextBox.TabIndex = 10;
            // 
            // replaceMatchCaseCheckBox
            // 
            this.replaceMatchCaseCheckBox.AutoSize = true;
            this.replaceMatchCaseCheckBox.Location = new System.Drawing.Point(12, 100);
            this.replaceMatchCaseCheckBox.Name = "replaceMatchCaseCheckBox";
            this.replaceMatchCaseCheckBox.Size = new System.Drawing.Size(82, 17);
            this.replaceMatchCaseCheckBox.TabIndex = 6;
            this.replaceMatchCaseCheckBox.Text = "Match case";
            this.replaceMatchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 153);
            this.Controls.Add(this.replaceMatchCaseCheckBox);
            this.Controls.Add(this.replaceWithTextBox);
            this.Controls.Add(this.replaceWithLabel);
            this.Controls.Add(this.replaceCancelButton);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.replaceFindNextButton);
            this.Controls.Add(this.replaceFindWhatTextBox);
            this.Controls.Add(this.replaceFindLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "replaceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label replaceFindLabel;
        private System.Windows.Forms.TextBox replaceFindWhatTextBox;
        private System.Windows.Forms.Button replaceFindNextButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button replaceAllButton;
        private System.Windows.Forms.Button replaceCancelButton;
        private System.Windows.Forms.Label replaceWithLabel;
        private System.Windows.Forms.TextBox replaceWithTextBox;
        private System.Windows.Forms.CheckBox replaceMatchCaseCheckBox;
    }
}