using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoAmI_PC
{
    public partial class WhoAmI : Form
    {
        string emailPassani;
        public WhoAmI(string email)
        {
            InitializeComponent();
            emailPassani = email;
            buttonBackToMenu.Enabled = false;
            buttonBackToMenu.Visible = false;
            labelQuestion.MaximumSize = new Size(574, 0);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProgramLogic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateCharacter_Click(object sender, EventArgs e)
        {
            CreateCharacter character = new CreateCharacter(emailPassani);
            character.ShowDialog();
        }

        //za displayanje charactera na screen
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            labelQuestion.Text = "Pick your character";
            listBoxCharactersPick.Enabled = true;
            listBoxCharactersPick.Visible = true;

            using (var context = new WhoAmIEntities())
            {
                var charactersList = context.Characters
                                        .Where(b => b.idPlayers == emailPassani);

                foreach (var result in charactersList)
                {
                    listBoxCharactersPick.Items.Add(result.Name);
                }
            }
        }


        TaskCompletionSource<bool> _tcs;
        //za biranje charactera i displayanja pitanja i odgovora
        private async void listBoxCharactersPick_DoubleClick(object sender, EventArgs e)
        {

            buttonBackToMenu.Enabled = true;
            buttonBackToMenu.Visible = true;
            buttonPlay.Enabled = false;
            buttonCreateCharacter.Enabled = false;
            listBoxCharactersPick.Visible = false;

            string characterSelectani = listBoxCharactersPick.GetItemText(listBoxCharactersPick.SelectedItem);

            using (var context = new WhoAmIEntities())
            {

                var intro = context.Characters
                                        .Where(b => b.idPlayers == emailPassani)
                                        .Where(b => b.Name == characterSelectani);
                var introMonolog = context.answers
                                        .Where(b => b.idLevels == 1)
                                        .Where(b => b.idStages == 1);



                foreach (var result in intro)
                {
                    if (result.intro == 0)
                    {
                        foreach (var resultMonolog in introMonolog)
                        {
                            labelQuestion.Text = resultMonolog.question;
                            await Task.Delay(4000);
                        }
                    }
                }

                //vadimo koliko ima razlicitih stageva
                var stagesRazliciti = context.answers
                                            .GroupBy(b => b.stagesDif)
                                            .Count();

                for (int i = 2; i <= stagesRazliciti; i++)
                {
                    var pitanja = context.answers
                                        .Where(b => b.idLevels == 1)
                                        .Where(b => b.idStages == i);
                    /*var karakter = context.Characters
                                        .Where(b => b.Name == characterSelectani)
                                        .Where(b => b.idPlayers == emailPassani);*/

                    foreach (var result in pitanja)
                    {
                        labelQuestion.Text = result.question;
                        labelAnswer1.Text = result.answ1;
                        labelAnswer2.Text = result.answ2;
                        labelAnswer3.Text = result.answ3;

                        _tcs = new TaskCompletionSource<bool>();
                        await _tcs.Task;

                    }

                }


            }
        }

        //za povratak u meni
        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            labelQuestion.Text = "";
            buttonPlay.Enabled = true;
            buttonCreateCharacter.Enabled = true;
            buttonBackToMenu.Visible = false;
            buttonBackToMenu.Enabled = false;
        }

        private void labelAnswer1_Click(object sender, EventArgs e)
        {
            _tcs.SetResult(false);
        }

        private void labelAnswer2_Click(object sender, EventArgs e)
        {
            _tcs.SetResult(false);
        }

        private void labelAnswer3_Click(object sender, EventArgs e)
        {
            _tcs.SetResult(false);
        }
    }
}
