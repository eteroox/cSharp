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
    public partial class glazba : Form
    {
        public glazba()
        {
            InitializeComponent();
        }

        private void glazba_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        string[] podatci, putanja;
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                podatci = open.SafeFileNames;
                putanja = open.FileNames;

                for (int i = 0; i < podatci.Length; i++)
                {
                    listBox1.Items.Add(podatci[i]);
                }
            }
        }

        //za selectau pjesmu da svira
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = putanja[listBox1.SelectedIndex];
        }

        //za prebacivanje na sljedecu nakon sto trenutna zavrsi
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timer1.Interval = 100;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < podatci.Length - 1)
            {
                listBox1.SelectedIndex++;
                timer1.Enabled = false;
            }
            else
            {
                listBox1.SelectedIndex = 0;
                timer1.Enabled = false;
            }
        }

    }
}
