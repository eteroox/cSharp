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
    public partial class findForm : Form
    {
        public findForm()
        {
            InitializeComponent();
        }

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            if (findTextBox.Text.Length > 0)
                findNextButton.Enabled = true;
            else
                findNextButton.Enabled = false;
        }

        private void findCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void findNextButton_Click(object sender, EventArgs e)
        {
            if(((TextPadMainForm)this.Owner).findText(findTextBox.Text,
                directionDownRadioButton.Checked,
                matchCaseCheckBox.Checked) == false)
            {
                MessageBox.Show("Can't find \'" + findTextBox.Text +
                    "\'", "Find", MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

    }
}
