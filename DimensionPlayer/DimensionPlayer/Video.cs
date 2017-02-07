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
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void Video_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Visible = true;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "( *.mp4) | *.mp4";
            if(open.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = open.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}
