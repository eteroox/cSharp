using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextPad1
{
    public partial class replaceForm : Form
    {
        public replaceForm()
        {
            InitializeComponent();
        }

        private void replaceFindNextButton_Click(object sender, EventArgs e)
        {
            if (((TextPadMainForm)this.Owner).findTextAll(replaceFindWhatTextBox.Text, 
               replaceMatchCaseCheckBox.Checked) == false)
            {
                MessageBox.Show("Can't find \'" + replaceFindWhatTextBox.Text +
                    "\'", "Find", MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }

        }

        private void replaceCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void replaceFindWhatTextBox_TextChanged(object sender, EventArgs e)
        {
            if(replaceFindWhatTextBox.Text.Length > 0)
            {
                replaceFindNextButton.Enabled = true;
                replaceAllButton.Enabled = true;
                replaceButton.Enabled = true;
            }
            else
            {
                replaceFindNextButton.Enabled = false;
                replaceAllButton.Enabled = false;
                replaceButton.Enabled = false;
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            if (((TextPadMainForm)this.Owner).findTextAll(replaceFindWhatTextBox.Text,
               replaceMatchCaseCheckBox.Checked) == false)
            {
                MessageBox.Show("Can't find \'" + replaceFindWhatTextBox.Text +
                    "\'", "Find", MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                ((TextPadMainForm)this.Owner).replaceText(replaceFindWhatTextBox.Text, replaceWithTextBox.Text);
            }
            
        }

        private void replaceAllButton_Click(object sender, EventArgs e)
        {

            if (((TextPadMainForm)this.Owner).findTextAll(replaceFindWhatTextBox.Text,
               replaceMatchCaseCheckBox.Checked) == false)
            {
                MessageBox.Show("Can't find \'" + replaceFindWhatTextBox.Text +
                    "\'", "Find", MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                ((TextPadMainForm)this.Owner).replaceAllText(replaceFindWhatTextBox.Text, replaceWithTextBox.Text);
            }
        }

    }
}
