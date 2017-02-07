using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptografskiUredajiSaveznika
{
    public partial class Sigaba : Form
    {
        public Sigaba()
        {
            InitializeComponent();
        }

        Main main = new Main();

        private void Sigaba_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        int i = 0;
        private void timerSigaba_Tick(object sender, EventArgs e)
        {
            i++;

            if (i == 5)
            {
                i = 0;
            }

            if (i == 0)
            {
                pictureBoxSlider.Image = Properties.Resources.sigaba;
            }
            if (i == 1)
            {
                pictureBoxSlider.Image = Properties.Resources.sigaba2;
            }
            if (i == 2)
            {
                pictureBoxSlider.Image = Properties.Resources.sigaba3;
            }
            if (i == 3)
            {
                pictureBoxSlider.Image = Properties.Resources.sigaba4;
            }
            if (i == 4)
            {
                pictureBoxSlider.Image = Properties.Resources.sigaba5;
            }
        }

        static int broj;

        private void Sigaba_Load(object sender, EventArgs e)
        {
            pictureBoxSlider.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSlider.Image = Properties.Resources.sigaba;



            using (var context = new uredajiEntities1())
            {
                var brojPitanja = context.porukes.Count();

                Random randomBroj = new Random();
                int rInt = randomBroj.Next(1, brojPitanja + 1);

                var randomText = context.porukes
                                        .Where(b => b.id == rInt);

                broj = rInt;

                foreach (var text in randomText)
                {
                    richTextBoxSavText.Text = text.sifriranoSigaba;
                }
            }
        }

        private void buttonSifre_Click(object sender, EventArgs e)
        {
            SigabaSifra sifraS = new SigabaSifra();
            sifraS.ShowDialog();

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string uneseniText = textBoxSifrirano.Text;

            using (var context = new uredajiEntities1())
            {
                var textIzBaze = context.porukes.Where(b => b.id == broj);

                foreach (var test in textIzBaze)
                {
                    if (test.desifrirano == uneseniText)
                    {
                        richTextBoxSavText.Text = test.konacno;
                    }
                    else
                    {
                        richTextBoxSavText.Text = test.greska;
                    }
                }

            }
        }

        private void buttonHowTo_Click(object sender, EventArgs e)
        {
            SigabaInfo sigaInfo = new SigabaInfo();
            sigaInfo.ShowDialog();
        }

        private void buttonScripta_Click(object sender, EventArgs e)
        {
            SigabaSkripta sSkripta = new SigabaSkripta();
            sSkripta.ShowDialog();
        }
    }
}
