namespace WhoAmI_PC
{
    partial class WhoAmI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhoAmI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonJournal = new System.Windows.Forms.Button();
            this.buttonCreateCharacter = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelTextCitanje = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerQuestionAnswers = new System.Windows.Forms.SplitContainer();
            this.listBoxCharactersPick = new System.Windows.Forms.ListBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswer3 = new System.Windows.Forms.Label();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuestionAnswers)).BeginInit();
            this.splitContainerQuestionAnswers.Panel1.SuspendLayout();
            this.splitContainerQuestionAnswers.Panel2.SuspendLayout();
            this.splitContainerQuestionAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 459);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.buttonBackToMenu);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Controls.Add(this.buttonJournal);
            this.panel3.Controls.Add(this.buttonCreateCharacter);
            this.panel3.Controls.Add(this.buttonPlay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MinimumSize = new System.Drawing.Size(200, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 459);
            this.panel3.TabIndex = 0;
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.Color.Yellow;
            this.buttonBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBackToMenu.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenu.Location = new System.Drawing.Point(0, 337);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(196, 59);
            this.buttonBackToMenu.TabIndex = 4;
            this.buttonBackToMenu.Text = "Back to Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(0, 396);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(196, 59);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonJournal
            // 
            this.buttonJournal.BackColor = System.Drawing.Color.White;
            this.buttonJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJournal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJournal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJournal.Location = new System.Drawing.Point(0, 118);
            this.buttonJournal.Name = "buttonJournal";
            this.buttonJournal.Size = new System.Drawing.Size(196, 59);
            this.buttonJournal.TabIndex = 0;
            this.buttonJournal.Text = "Journal";
            this.buttonJournal.UseVisualStyleBackColor = false;
            // 
            // buttonCreateCharacter
            // 
            this.buttonCreateCharacter.BackColor = System.Drawing.Color.White;
            this.buttonCreateCharacter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateCharacter.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateCharacter.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateCharacter.Location = new System.Drawing.Point(0, 59);
            this.buttonCreateCharacter.Name = "buttonCreateCharacter";
            this.buttonCreateCharacter.Size = new System.Drawing.Size(196, 59);
            this.buttonCreateCharacter.TabIndex = 1;
            this.buttonCreateCharacter.Text = "Create Character";
            this.buttonCreateCharacter.UseVisualStyleBackColor = false;
            this.buttonCreateCharacter.Click += new System.EventHandler(this.buttonCreateCharacter_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Lime;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(0, 0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(196, 59);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 459);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // labelTextCitanje
            // 
            this.labelTextCitanje.AutoSize = true;
            this.labelTextCitanje.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextCitanje.Location = new System.Drawing.Point(7, 13);
            this.labelTextCitanje.Name = "labelTextCitanje";
            this.labelTextCitanje.Size = new System.Drawing.Size(0, 23);
            this.labelTextCitanje.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitContainerQuestionAnswers);
            this.panel1.Controls.Add(this.labelTextCitanje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 459);
            this.panel1.TabIndex = 3;
            // 
            // splitContainerQuestionAnswers
            // 
            this.splitContainerQuestionAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerQuestionAnswers.Location = new System.Drawing.Point(0, 0);
            this.splitContainerQuestionAnswers.Name = "splitContainerQuestionAnswers";
            this.splitContainerQuestionAnswers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerQuestionAnswers.Panel1
            // 
            this.splitContainerQuestionAnswers.Panel1.AutoScroll = true;
            this.splitContainerQuestionAnswers.Panel1.Controls.Add(this.listBoxCharactersPick);
            this.splitContainerQuestionAnswers.Panel1.Controls.Add(this.labelQuestion);
            this.splitContainerQuestionAnswers.Panel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainerQuestionAnswers.Panel2
            // 
            this.splitContainerQuestionAnswers.Panel2.AutoScroll = true;
            this.splitContainerQuestionAnswers.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainerQuestionAnswers.Panel2.Controls.Add(this.labelAnswer3);
            this.splitContainerQuestionAnswers.Panel2.Controls.Add(this.labelAnswer2);
            this.splitContainerQuestionAnswers.Panel2.Controls.Add(this.labelAnswer1);
            this.splitContainerQuestionAnswers.Size = new System.Drawing.Size(574, 459);
            this.splitContainerQuestionAnswers.SplitterDistance = 335;
            this.splitContainerQuestionAnswers.TabIndex = 1;
            // 
            // listBoxCharactersPick
            // 
            this.listBoxCharactersPick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCharactersPick.Enabled = false;
            this.listBoxCharactersPick.FormattingEnabled = true;
            this.listBoxCharactersPick.ItemHeight = 26;
            this.listBoxCharactersPick.Location = new System.Drawing.Point(84, 57);
            this.listBoxCharactersPick.Name = "listBoxCharactersPick";
            this.listBoxCharactersPick.Size = new System.Drawing.Size(368, 264);
            this.listBoxCharactersPick.TabIndex = 2;
            this.listBoxCharactersPick.Visible = false;
            this.listBoxCharactersPick.DoubleClick += new System.EventHandler(this.listBoxCharactersPick_DoubleClick);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(29, 13);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(0, 26);
            this.labelQuestion.TabIndex = 1;
            // 
            // labelAnswer3
            // 
            this.labelAnswer3.AutoSize = true;
            this.labelAnswer3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer3.Location = new System.Drawing.Point(11, 75);
            this.labelAnswer3.Name = "labelAnswer3";
            this.labelAnswer3.Size = new System.Drawing.Size(0, 20);
            this.labelAnswer3.TabIndex = 2;
            this.labelAnswer3.Click += new System.EventHandler(this.labelAnswer3_Click);
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer2.Location = new System.Drawing.Point(11, 46);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(0, 20);
            this.labelAnswer2.TabIndex = 1;
            this.labelAnswer2.Click += new System.EventHandler(this.labelAnswer2_Click);
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer1.Location = new System.Drawing.Point(11, 15);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(0, 20);
            this.labelAnswer1.TabIndex = 0;
            this.labelAnswer1.Click += new System.EventHandler(this.labelAnswer1_Click);
            // 
            // WhoAmI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(780, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhoAmI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhoAmI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramLogic_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainerQuestionAnswers.Panel1.ResumeLayout(false);
            this.splitContainerQuestionAnswers.Panel1.PerformLayout();
            this.splitContainerQuestionAnswers.Panel2.ResumeLayout(false);
            this.splitContainerQuestionAnswers.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuestionAnswers)).EndInit();
            this.splitContainerQuestionAnswers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonCreateCharacter;
        private System.Windows.Forms.Button buttonJournal;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTextCitanje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainerQuestionAnswers;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.ListBox listBoxCharactersPick;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Label labelAnswer3;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.Label labelAnswer1;
    }
}