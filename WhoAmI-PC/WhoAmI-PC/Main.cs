using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoAmI_PC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Lime;
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.CornflowerBlue;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Lime;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.CornflowerBlue;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            using (var context = new WhoAmIEntities())
            {
                var username = context.players
                                        .Where(b => b.email == textBoxUsername.Text)
                                        .Where(b => b.password == textBoxPassword.Text);

                foreach (var blog in username)
                {
                    if (blog.email == textBoxUsername.Text && blog.password == textBoxPassword.Text)
                    {
                        WhoAmI prog = new WhoAmI(textBoxUsername.Text);
                        prog.Show();
                        this.Hide();
                    }
                }
            }
        }

        int i = 0;
        private void timerSlider_Tick(object sender, EventArgs e)
        {
            i++;

            if ( i==3 )
            {
                i = 0;
            }

            if (i == 0)
            {
                pictureBoxLogin.Image = Properties.Resources.LoginPart;
            }
            if (i == 1)
            {
                pictureBoxLogin.Image = Properties.Resources.face;
            }
            if (i == 2)
            {
                pictureBoxLogin.Image = Properties.Resources.Simbol;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.Image = Properties.Resources.LoginPart;
        }
    }
}
