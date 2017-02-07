using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionPlayer
{
    public partial class youtube : Form
    {
        public youtube()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.youtube.com");
        }

        private void youtube_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Visible = true;
        }
    }
}
