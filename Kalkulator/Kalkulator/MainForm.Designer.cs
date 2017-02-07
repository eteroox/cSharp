namespace Kalkulator
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
            this.tBoxDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnNum1 = new System.Windows.Forms.Button();
            this.bttnNum2 = new System.Windows.Forms.Button();
            this.bttnNum3 = new System.Windows.Forms.Button();
            this.bttnNum4 = new System.Windows.Forms.Button();
            this.bttnNum5 = new System.Windows.Forms.Button();
            this.bttnNum6 = new System.Windows.Forms.Button();
            this.bttnNum7 = new System.Windows.Forms.Button();
            this.bttnNum8 = new System.Windows.Forms.Button();
            this.bttnNum9 = new System.Windows.Forms.Button();
            this.bttnPreznak = new System.Windows.Forms.Button();
            this.bttnDecTocka = new System.Windows.Forms.Button();
            this.bttnNum0 = new System.Windows.Forms.Button();
            this.bttnZbrajanje = new System.Windows.Forms.Button();
            this.bttnIzracunaj = new System.Windows.Forms.Button();
            this.bttnOduzimanje = new System.Windows.Forms.Button();
            this.bttnCE = new System.Windows.Forms.Button();
            this.bttnMnozenje = new System.Windows.Forms.Button();
            this.bttnC = new System.Windows.Forms.Button();
            this.bttnDijeljenje = new System.Windows.Forms.Button();
            this.bttnBackSpace = new System.Windows.Forms.Button();
            this.textBoxOperacije = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxDisplay
            // 
            this.tBoxDisplay.BackColor = System.Drawing.Color.White;
            this.tBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxDisplay.ForeColor = System.Drawing.Color.Black;
            this.tBoxDisplay.Location = new System.Drawing.Point(12, 69);
            this.tBoxDisplay.Name = "tBoxDisplay";
            this.tBoxDisplay.ReadOnly = true;
            this.tBoxDisplay.Size = new System.Drawing.Size(260, 31);
            this.tBoxDisplay.TabIndex = 0;
            this.tBoxDisplay.Text = "0";
            this.tBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxDisplay.TextChanged += new System.EventHandler(this.tBoxDisplay_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.bttnNum1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnPreznak, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnDecTocka, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnNum0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnZbrajanje, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnIzracunaj, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnOduzimanje, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnCE, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnMnozenje, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnC, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnDijeljenje, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnBackSpace, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 171);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bttnNum1
            // 
            this.bttnNum1.Location = new System.Drawing.Point(3, 87);
            this.bttnNum1.Name = "bttnNum1";
            this.bttnNum1.Size = new System.Drawing.Size(37, 36);
            this.bttnNum1.TabIndex = 1;
            this.bttnNum1.Text = "1";
            this.bttnNum1.UseVisualStyleBackColor = true;
            this.bttnNum1.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnNum2
            // 
            this.bttnNum2.Location = new System.Drawing.Point(46, 87);
            this.bttnNum2.Name = "bttnNum2";
            this.bttnNum2.Size = new System.Drawing.Size(37, 36);
            this.bttnNum2.TabIndex = 2;
            this.bttnNum2.Text = "2";
            this.bttnNum2.UseVisualStyleBackColor = true;
            this.bttnNum2.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnNum3
            // 
            this.bttnNum3.Location = new System.Drawing.Point(89, 87);
            this.bttnNum3.Name = "bttnNum3";
            this.bttnNum3.Size = new System.Drawing.Size(37, 36);
            this.bttnNum3.TabIndex = 3;
            this.bttnNum3.Text = "3";
            this.bttnNum3.UseVisualStyleBackColor = true;
            this.bttnNum3.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnNum4
            // 
            this.bttnNum4.Location = new System.Drawing.Point(3, 45);
            this.bttnNum4.Name = "bttnNum4";
            this.bttnNum4.Size = new System.Drawing.Size(37, 36);
            this.bttnNum4.TabIndex = 4;
            this.bttnNum4.Text = "4";
            this.bttnNum4.UseVisualStyleBackColor = true;
            this.bttnNum4.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnNum5
            // 
            this.bttnNum5.Location = new System.Drawing.Point(46, 45);
            this.bttnNum5.Name = "bttnNum5";
            this.bttnNum5.Size = new System.Drawing.Size(37, 36);
            this.bttnNum5.TabIndex = 5;
            this.bttnNum5.Text = "5";
            this.bttnNum5.UseVisualStyleBackColor = true;
            this.bttnNum5.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnNum6
            // 
            this.bttnNum6.Location = new System.Drawing.Point(89, 45);
            this.bttnNum6.Name = "bttnNum6";
            this.bttnNum6.Size = new System.Drawing.Size(37, 36);
            this.bttnNum6.TabIndex = 6;
            this.bttnNum6.Text = "6";
            this.bttnNum6.UseVisualStyleBackColor = true;
            this.bttnNum6.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnNum7
            // 
            this.bttnNum7.Location = new System.Drawing.Point(3, 3);
            this.bttnNum7.Name = "bttnNum7";
            this.bttnNum7.Size = new System.Drawing.Size(37, 36);
            this.bttnNum7.TabIndex = 7;
            this.bttnNum7.Text = "7";
            this.bttnNum7.UseVisualStyleBackColor = true;
            this.bttnNum7.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnNum8
            // 
            this.bttnNum8.Location = new System.Drawing.Point(46, 3);
            this.bttnNum8.Name = "bttnNum8";
            this.bttnNum8.Size = new System.Drawing.Size(37, 36);
            this.bttnNum8.TabIndex = 8;
            this.bttnNum8.Text = "8";
            this.bttnNum8.UseVisualStyleBackColor = true;
            this.bttnNum8.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnNum9
            // 
            this.bttnNum9.Location = new System.Drawing.Point(89, 3);
            this.bttnNum9.Name = "bttnNum9";
            this.bttnNum9.Size = new System.Drawing.Size(37, 36);
            this.bttnNum9.TabIndex = 9;
            this.bttnNum9.Text = "9";
            this.bttnNum9.UseVisualStyleBackColor = true;
            this.bttnNum9.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnPreznak
            // 
            this.bttnPreznak.Location = new System.Drawing.Point(89, 129);
            this.bttnPreznak.Name = "bttnPreznak";
            this.bttnPreznak.Size = new System.Drawing.Size(37, 39);
            this.bttnPreznak.TabIndex = 11;
            this.bttnPreznak.Text = "+/-";
            this.bttnPreznak.UseVisualStyleBackColor = true;
            this.bttnPreznak.Click += new System.EventHandler(this.bttnPreznak_Click);
            // 
            // bttnDecTocka
            // 
            this.bttnDecTocka.Location = new System.Drawing.Point(3, 129);
            this.bttnDecTocka.Name = "bttnDecTocka";
            this.bttnDecTocka.Size = new System.Drawing.Size(37, 39);
            this.bttnDecTocka.TabIndex = 10;
            this.bttnDecTocka.Text = ",";
            this.bttnDecTocka.UseVisualStyleBackColor = true;
            this.bttnDecTocka.Click += new System.EventHandler(this.bttnDecTocka_Click);
            this.bttnDecTocka.MouseEnter += new System.EventHandler(this.bttn_MouseEnter);
            this.bttnDecTocka.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            // 
            // bttnNum0
            // 
            this.bttnNum0.Location = new System.Drawing.Point(46, 129);
            this.bttnNum0.Name = "bttnNum0";
            this.bttnNum0.Size = new System.Drawing.Size(37, 39);
            this.bttnNum0.TabIndex = 0;
            this.bttnNum0.Text = "0";
            this.bttnNum0.UseVisualStyleBackColor = true;
            this.bttnNum0.Click += new System.EventHandler(this.bttnFunkcija);
            // 
            // bttnZbrajanje
            // 
            this.bttnZbrajanje.Location = new System.Drawing.Point(175, 129);
            this.bttnZbrajanje.Name = "bttnZbrajanje";
            this.bttnZbrajanje.Size = new System.Drawing.Size(37, 39);
            this.bttnZbrajanje.TabIndex = 12;
            this.bttnZbrajanje.Text = "+";
            this.bttnZbrajanje.UseVisualStyleBackColor = true;
            this.bttnZbrajanje.Click += new System.EventHandler(this.buttonOperand_Click);
            // 
            // bttnIzracunaj
            // 
            this.bttnIzracunaj.Location = new System.Drawing.Point(218, 129);
            this.bttnIzracunaj.Name = "bttnIzracunaj";
            this.bttnIzracunaj.Size = new System.Drawing.Size(39, 39);
            this.bttnIzracunaj.TabIndex = 13;
            this.bttnIzracunaj.Text = "=";
            this.bttnIzracunaj.UseVisualStyleBackColor = true;
            this.bttnIzracunaj.Click += new System.EventHandler(this.izracunaj_Click);
            // 
            // bttnOduzimanje
            // 
            this.bttnOduzimanje.Location = new System.Drawing.Point(175, 87);
            this.bttnOduzimanje.Name = "bttnOduzimanje";
            this.bttnOduzimanje.Size = new System.Drawing.Size(37, 36);
            this.bttnOduzimanje.TabIndex = 14;
            this.bttnOduzimanje.Text = "-";
            this.bttnOduzimanje.UseVisualStyleBackColor = true;
            this.bttnOduzimanje.Click += new System.EventHandler(this.buttonOperand_Click);
            // 
            // bttnCE
            // 
            this.bttnCE.Location = new System.Drawing.Point(218, 87);
            this.bttnCE.Name = "bttnCE";
            this.bttnCE.Size = new System.Drawing.Size(39, 36);
            this.bttnCE.TabIndex = 15;
            this.bttnCE.Text = "CE";
            this.bttnCE.UseVisualStyleBackColor = true;
            this.bttnCE.Click += new System.EventHandler(this.bttnCE_Click);
            // 
            // bttnMnozenje
            // 
            this.bttnMnozenje.Location = new System.Drawing.Point(175, 45);
            this.bttnMnozenje.Name = "bttnMnozenje";
            this.bttnMnozenje.Size = new System.Drawing.Size(37, 36);
            this.bttnMnozenje.TabIndex = 16;
            this.bttnMnozenje.Text = "*";
            this.bttnMnozenje.UseVisualStyleBackColor = true;
            this.bttnMnozenje.Click += new System.EventHandler(this.buttonOperand_Click);
            // 
            // bttnC
            // 
            this.bttnC.Location = new System.Drawing.Point(218, 45);
            this.bttnC.Name = "bttnC";
            this.bttnC.Size = new System.Drawing.Size(39, 36);
            this.bttnC.TabIndex = 17;
            this.bttnC.Text = "C";
            this.bttnC.UseVisualStyleBackColor = true;
            this.bttnC.Click += new System.EventHandler(this.bttnC_Click);
            // 
            // bttnDijeljenje
            // 
            this.bttnDijeljenje.Location = new System.Drawing.Point(175, 3);
            this.bttnDijeljenje.Name = "bttnDijeljenje";
            this.bttnDijeljenje.Size = new System.Drawing.Size(37, 36);
            this.bttnDijeljenje.TabIndex = 18;
            this.bttnDijeljenje.Text = "/";
            this.bttnDijeljenje.UseVisualStyleBackColor = true;
            this.bttnDijeljenje.Click += new System.EventHandler(this.buttonOperand_Click);
            // 
            // bttnBackSpace
            // 
            this.bttnBackSpace.Location = new System.Drawing.Point(218, 3);
            this.bttnBackSpace.Name = "bttnBackSpace";
            this.bttnBackSpace.Size = new System.Drawing.Size(39, 36);
            this.bttnBackSpace.TabIndex = 19;
            this.bttnBackSpace.Text = "<-";
            this.bttnBackSpace.UseVisualStyleBackColor = true;
            this.bttnBackSpace.Click += new System.EventHandler(this.bttnBackSpace_Click);
            // 
            // textBoxOperacije
            // 
            this.textBoxOperacije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOperacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOperacije.ForeColor = System.Drawing.Color.Red;
            this.textBoxOperacije.Location = new System.Drawing.Point(12, 43);
            this.textBoxOperacije.Name = "textBoxOperacije";
            this.textBoxOperacije.ReadOnly = true;
            this.textBoxOperacije.Size = new System.Drawing.Size(260, 20);
            this.textBoxOperacije.TabIndex = 2;
            this.textBoxOperacije.Text = "0";
            this.textBoxOperacije.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.programmerToolStripMenuItem,
            this.scientificToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(186, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(98, 262);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.programmerToolStripMenuItem.Text = "Programmer";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.scientificToolStripMenuItem.Text = "Scientific";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(280, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 288);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.textBoxOperacije);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tBoxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Kalkulator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttnNum0;
        private System.Windows.Forms.Button bttnNum1;
        private System.Windows.Forms.Button bttnNum2;
        private System.Windows.Forms.Button bttnNum3;
        private System.Windows.Forms.Button bttnNum4;
        private System.Windows.Forms.Button bttnNum5;
        private System.Windows.Forms.Button bttnNum6;
        private System.Windows.Forms.Button bttnNum7;
        private System.Windows.Forms.Button bttnNum8;
        private System.Windows.Forms.Button bttnNum9;
        private System.Windows.Forms.Button bttnPreznak;
        private System.Windows.Forms.Button bttnDecTocka;
        private System.Windows.Forms.Button bttnZbrajanje;
        private System.Windows.Forms.Button bttnIzracunaj;
        private System.Windows.Forms.Button bttnOduzimanje;
        private System.Windows.Forms.Button bttnCE;
        private System.Windows.Forms.Button bttnMnozenje;
        private System.Windows.Forms.Button bttnC;
        private System.Windows.Forms.Button bttnDijeljenje;
        private System.Windows.Forms.Button bttnBackSpace;
        private System.Windows.Forms.TextBox textBoxOperacije;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

