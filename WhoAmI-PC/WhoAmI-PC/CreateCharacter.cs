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
    public partial class CreateCharacter : Form
    {
        string emailPasani;
        public CreateCharacter(string email)
        {
            InitializeComponent();
            emailPasani = email;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            CreateCharacter cc = new CreateCharacter(emailPasani);
            this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            using (var context = new WhoAmIEntities())
            {
                Character unos = new Character
                {
                    Name = textBoxName.Text,
                    idPlayers = emailPasani,
                    intro = 0
                };

                var postojiLi = context.Characters.Where(b => b.Name == textBoxName.Text);
                var postojiLiInt = context.Characters.Where(b => b.Name == textBoxName.Text).Count();
                foreach (var blog in postojiLi)
                {
                    if (blog.Name == textBoxName.Text)
                    {
                        labelCharacterExists.Text = "Character already exists";
                        this.Close();
                    }
                }
                int x = 0;
                if (postojiLiInt == x)
                {
                    labelCharacterExists.Text = "Character added";
                    context.Characters.Add(unos);
                    context.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
