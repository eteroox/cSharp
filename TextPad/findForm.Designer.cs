namespace TextPad1
{
    partial class findForm
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
            this.findNextLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.directionGroupBox = new System.Windows.Forms.GroupBox();
            this.directionDownRadioButton = new System.Windows.Forms.RadioButton();
            this.directionUpRadioButton = new System.Windows.Forms.RadioButton();
            this.findNextButton = new System.Windows.Forms.Button();
            this.findCancelButton = new System.Windows.Forms.Button();
            this.directionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // findNextLabel
            // 
            this.findNextLabel.AutoSize = true;
            this.findNextLabel.Location = new System.Drawing.Point(3, 13);
            this.findNextLabel.Name = "findNextLabel";
            this.findNextLabel.Size = new System.Drawing.Size(56, 13);
            this.findNextLabel.TabIndex = 0;
            this.findNextLabel.Text = "Find what:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(74, 10);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(190, 20);
            this.findTextBox.TabIndex = 1;
            this.findTextBox.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(6, 69);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(82, 17);
            this.matchCaseCheckBox.TabIndex = 2;
            this.matchCaseCheckBox.Text = "Match case";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // directionGroupBox
            // 
            this.directionGroupBox.Controls.Add(this.directionDownRadioButton);
            this.directionGroupBox.Controls.Add(this.directionUpRadioButton);
            this.directionGroupBox.Location = new System.Drawing.Point(160, 42);
            this.directionGroupBox.Name = "directionGroupBox";
            this.directionGroupBox.Size = new System.Drawing.Size(104, 48);
            this.directionGroupBox.TabIndex = 3;
            this.directionGroupBox.TabStop = false;
            this.directionGroupBox.Text = "Direction";
            // 
            // directionDownRadioButton
            // 
            this.directionDownRadioButton.AutoSize = true;
            this.directionDownRadioButton.Checked = true;
            this.directionDownRadioButton.Location = new System.Drawing.Point(45, 23);
            this.directionDownRadioButton.Name = "directionDownRadioButton";
            this.directionDownRadioButton.Size = new System.Drawing.Size(53, 17);
            this.directionDownRadioButton.TabIndex = 1;
            this.directionDownRadioButton.TabStop = true;
            this.directionDownRadioButton.Text = "Down";
            this.directionDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // directionUpRadioButton
            // 
            this.directionUpRadioButton.AutoSize = true;
            this.directionUpRadioButton.Location = new System.Drawing.Point(6, 23);
            this.directionUpRadioButton.Name = "directionUpRadioButton";
            this.directionUpRadioButton.Size = new System.Drawing.Size(39, 17);
            this.directionUpRadioButton.TabIndex = 0;
            this.directionUpRadioButton.Text = "Up";
            this.directionUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // findNextButton
            // 
            this.findNextButton.Enabled = false;
            this.findNextButton.Location = new System.Drawing.Point(274, 8);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(74, 23);
            this.findNextButton.TabIndex = 4;
            this.findNextButton.Text = "Find Next";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.findNextButton_Click);
            // 
            // findCancelButton
            // 
            this.findCancelButton.Location = new System.Drawing.Point(273, 37);
            this.findCancelButton.Name = "findCancelButton";
            this.findCancelButton.Size = new System.Drawing.Size(75, 23);
            this.findCancelButton.TabIndex = 5;
            this.findCancelButton.Text = "Cancel";
            this.findCancelButton.UseVisualStyleBackColor = true;
            this.findCancelButton.Click += new System.EventHandler(this.findCancelButton_Click);
            // 
            // findForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 101);
            this.Controls.Add(this.findCancelButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.directionGroupBox);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findNextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "findForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.directionGroupBox.ResumeLayout(false);
            this.directionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findNextLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.GroupBox directionGroupBox;
        private System.Windows.Forms.RadioButton directionDownRadioButton;
        private System.Windows.Forms.RadioButton directionUpRadioButton;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Button findCancelButton;
    }
}