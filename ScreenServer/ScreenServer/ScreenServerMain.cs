using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenServer
{
    public partial class ScreenServerMain : Form
    {
        public ScreenServerMain()
        {
            InitializeComponent();
        }

        private Point mouseLocation;

        //izbaceno zbog mogučnosti mijenjanja pjesma na screenserveru
        private void ScreenServerMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                if (Math.Abs(mouseLocation.X - e.X) > 2 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 2)
                    Application.Exit();
            }

            mouseLocation = e.Location;

        }

        private void ScreenServerMain_Shown(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.youtube.com/watch?v=yJ7XSt8YuSw&list=PLujdU3QPsrl-L7tBXPYe1baEQUVS-dKO4");
        }

    }
}
