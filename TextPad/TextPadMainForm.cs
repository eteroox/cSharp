using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace TextPad1
{
    public partial class TextPadMainForm : Form
    {
        StreamReader readFile;
        string fileName;
        int selectionPos = 0;
        findForm findDialog;
        replaceForm replaceDialog;

        int selectionStart=0;

        public TextPadMainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.readFile != null)
                {
                    this.readFile.Close();
                }
                this.readFile = new StreamReader(this.openFileDialog.FileName);
                this.textBox.Text = this.readFile.ReadToEnd();
                this.fileName = this.openFileDialog.FileName;
                this.Text = this.openFileDialog.SafeFileName + " - MyNotepad";
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.readFile != null)
                {
                    this.readFile.Close();
                }
                StreamWriter saveFile = new StreamWriter(this.saveFileDialog.FileName);
                saveFile.Write(this.textBox.Text);
                saveFile.Flush();
                saveFile.Close();
                this.readFile = new StreamReader(this.saveFileDialog.FileName);
                this.fileName = this.saveFileDialog.FileName;
                this.Text = this.saveFileDialog.FileName.Substring(
                    this.saveFileDialog.FileName.LastIndexOf('\\') + 1) + " - MyNotepad";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fileName == null)
            {
                this.saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                if (this.readFile != null)
                {
                    this.readFile.Close();
                }
                StreamWriter saveFile = new StreamWriter(this.fileName);
                saveFile.Write(this.textBox.Text);
                saveFile.Flush();
                saveFile.Close();
                this.readFile = new StreamReader(this.fileName);
                this.Text = this.fileName.Substring(
                    this.fileName.LastIndexOf('\\') + 1) + " - MyNotepad";
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetupDialog.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.readFile != null)
            {
                this.readFile.Close();
            }
            this.fileName = null;
            this.textBox.Clear();
            this.Text = "MyNotepad";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int posStart = textBox.SelectionStart;
            int posEnd = textBox.SelectionStart + textBox.SelectionLength;
            int length = textBox.SelectionLength;

            char[] text = textBox.Text.ToCharArray();

            if (length > 0) 
            {
                for (int i = posEnd; i < text.Length; i++)
                {
                    text[i - length] = text[i];
                }
                text[text.Length - length] = '\0';
            }
            else if(text.Length > 0)
            {
                for (int i = posStart; i < text.Length-1; i++)
                {
                    text[i] = text[i + 1];
                }
                text[text.Length - 1] = '\0';
            }
            textBox.Text = new string(text);
            textBox.SelectionStart = posStart;

        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pos = textBox.SelectionStart;
            string dateFormat = "hh:mm dd.MM.yyyy.";
            textBox.Text = textBox.Text.Insert(pos, 
                DateTime.Now.ToString(dateFormat));
            textBox.SelectionStart = pos + dateFormat.Length;
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Napravio Denis Alibašić", "Autor");
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusStrip.Visible.Equals(false))
            {
                statusStrip.Show();
            }
            else
            {
                statusStrip.Hide();
            }
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(
                printDocument_PrintPage);

            if (this.printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawString(textBox.Text, textBox.Font, Brushes.Black, 0, 0);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = fontDialog.Color;
                textBox.Font = fontDialog.Font;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                findDialog = new findForm();
                findDialog.Owner = this;
                findDialog.ShowDialog();
            
        }
        
        protected internal bool findText(string textToFind,
              bool searchDirectionDown, bool matchCase)
        { 
              try
              {
                  this.Focus();
                  textBox.Focus();

                  if (searchDirectionDown == true)
                  {
                      if (matchCase == false)
                      {
                          selectionPos = textBox.Text.Substring(selectionPos).IndexOf(textToFind, 
                              StringComparison.InvariantCultureIgnoreCase) + selectionPos;

                          if (textBox.Text.Substring(selectionPos, textToFind.Length).Equals(textToFind, 
                              StringComparison.InvariantCultureIgnoreCase))
                              textBox.Select(selectionPos, textToFind.Length);
                          else
                              return false;
                      }
                      else
                      {
                          selectionPos = textBox.Text.Substring(selectionPos).IndexOf(textToFind) + selectionPos;

                          if (textBox.Text.Substring(selectionPos, textToFind.Length).Equals(textToFind))
                              textBox.Select(selectionPos, textToFind.Length);
                          else
                              return false;
                      }

                      selectionPos += textToFind.Length;

                  }
                  else
                  {
                      if (matchCase == false)
                      {
                          selectionPos = textBox.Text.Substring(0, selectionPos).LastIndexOf(textToFind,
                              StringComparison.InvariantCultureIgnoreCase);
                          //toolStripStatusLabel.Text = "" + selectionPos;

                          if (textBox.Text.Substring(selectionPos, textToFind.Length).Equals(textToFind,
                              StringComparison.InvariantCultureIgnoreCase))
                              textBox.Select(selectionPos, textToFind.Length);
                          else
                              return false;
                      }
                      else
                      {
                          selectionPos = textBox.Text.Substring(0, selectionPos).LastIndexOf(textToFind);
                          //toolStripStatusLabel.Text = "" + selectionPos;
                          if (textBox.Text.Substring(selectionPos, textToFind.Length).Equals(textToFind))
                              textBox.Select(selectionPos, textToFind.Length);
                          else
                              return false;
                      }
                      selectionPos -= textToFind.Length;
                  }

                  return true;


              }
              catch
              {
                  selectionPos = 0;
                  return false;              
              }
 
          }

        protected internal bool findTextAll(string textToFind, bool matchCase)
        {
            try
            {
                this.Focus();
                textBox.Focus();

                    if (matchCase == false)
                    {
                        selectionPos = textBox.Text.Substring(selectionPos).IndexOf(textToFind,
                            StringComparison.InvariantCultureIgnoreCase) + selectionPos;

                        if (textBox.Text.Substring(selectionPos, textToFind.Length).Equals(textToFind,
                            StringComparison.InvariantCultureIgnoreCase))
                            textBox.Select(selectionPos, textToFind.Length);
                        else
                            return false;
                    }
                    else
                    {
                        selectionPos = textBox.Text.Substring(selectionPos).IndexOf(textToFind) + selectionPos;

                        if (textBox.Text.Substring(selectionPos, textToFind.Length).Equals(textToFind))
                            textBox.Select(selectionPos, textToFind.Length);
                        else
                            return false;
                    }

                    selectionPos += textToFind.Length;
               
                return true;


            }
            catch
            {
                selectionPos = 0;
                return false;
            }

        }

        protected internal bool replaceAllText(string oldText, string newText)
        {
            try
            {
                textBox.Text = textBox.Text.Replace(oldText, newText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected internal bool replaceText(string oldText, string newText)
        {
            try
            {
                selectionPos -= oldText.Length;
                
                textBox.Text = textBox.Text.Substring(0, selectionPos) + newText + textBox.Text.Substring(selectionPos + oldText.Length);
                textBox.Select(selectionPos, newText.Length);

                return true;
            }
            catch
            {
                return false;
            }
        }


        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findDialog.Owner = this;
            findDialog.findNextButton_Click(sender, e);
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectionPos = 0;
            if (textBox.Text.Length > 0)
            {
                replaceDialog = new replaceForm();
                replaceDialog.Owner = this;
                replaceDialog.ShowDialog();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string chars = textBox.Text;
            int numOfChars = chars.Length;

            if (numOfChars > 0)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 10 || chars[i] == 13)
                    {
                        --numOfChars;
                    }
                }

                int currentLine = textBox.GetLineFromCharIndex(this.textBox.SelectionStart) + 1;

                toolStripStatusLabel.Text = "Rows in total: " + textBox.Lines.Length +
                    " | Characters in total: " + numOfChars +
                    " | Current line: " + currentLine +
                    " | Chars in current line: " + textBox.Lines[currentLine - 1].Length
                    ;
            }
             
        }

        private void font1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog ft = new FontDialog();
            ft.ShowDialog();
            ft.Font = fontDialog.Font;
        }

        private void openNoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            readFile = new StreamReader(openFileDialog.OpenFile());
            textBox.Text = readFile.ReadToEnd();
        }

        private void saveNoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            StreamWriter save = new StreamWriter(fileName);
            save.Write(textBox.Text);
        }

    }
}
