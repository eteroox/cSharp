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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGlazba_Click(object sender, EventArgs e)
        {
            glazba glazba = new glazba();
            this.Hide();
            glazba.Show();
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            Video video = new Video();
            this.Visible = false;
            video.Show();
        }

        private void buttonYoutube_Click(object sender, EventArgs e)
        {
            youtube youtube = new youtube();
            this.Visible = false;
            youtube.Show();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}
