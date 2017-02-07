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
    public partial class TypexPc : Form
    {
        public TypexPc()
        {
            InitializeComponent();
        }

        Main main = new Main();

        private void TypexPc_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        int i = 0;

        private void timerTypex_Tick(object sender, EventArgs e)
        {
            i++;

            if (i == 6)
            {
                i = 0;
            }

            if (i == 0)
            {
                pictureBoxSlider.Image = Properties.Resources.typex;
            }
            if (i == 1)
            {
                pictureBoxSlider.Image = Properties.Resources.typex2;
            }
            if (i == 2)
            {
                pictureBoxSlider.Image = Properties.Resources.typex3;
            }
            if (i == 3)
            {
                pictureBoxSlider.Image = Properties.Resources.typex4;
            }
            if (i == 4)
            {
                pictureBoxSlider.Image = Properties.Resources.typex5;
            }
            if (i == 5)
            {
                pictureBoxSlider.Image = Properties.Resources.typex6;
            }
        }

        static int broj;

        private void TypexPc_Load(object sender, EventArgs e)
        {
            pictureBoxSlider.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSlider.Image = Properties.Resources.typex;

            using (var context = new uredajiEntities1())
            {
                var brojPitanja = context.porukes.Count();

                Random randomBroj = new Random();
                int rInt = randomBroj.Next(1, brojPitanja+1);

                var randomText = context.porukes
                                        .Where(b => b.id == rInt);

                broj = rInt;


                foreach (var text in randomText)
                {
                    richTextBoxSavText.Text = text.desifrirano;
                }
                
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            string uneseniText = textBoxSifrirano.Text;

            string prvi="", drugi="", treci="";

            if (broj == 1)
            {
                prvi = "23";
                drugi = "2";
                treci = "6";
            }
            if (broj == 2)
            {
                prvi = "19";
                drugi = "2";
                treci = "3";
            }
            if (broj == 3)
            {
                prvi = "2";
                drugi = "2";
                treci = "3";
            }
            if (broj == 4)
            {
                prvi = "2";
                drugi = "2";
                treci = "3";
            }

            using (var context = new uredajiEntities1())
            {
                var textIzBaze = context.porukes.Where(b => b.id == broj);

                foreach (var test in textIzBaze)
                {
                    if (test.sifrirano == uneseniText && prvi==textBoxPrviBroj.Text && drugi==textBoxDrugiBroj.Text && treci==textBoxTreciBroj.Text)
                    {
                        richTextBoxSavText.Text = test.konacno;
                    }else{
                        richTextBoxSavText.Text = test.greska;
                    }
                }

            }

        }

        private void buttonHowTo_Click(object sender, EventArgs e)
        {
            TypexInfo ty = new TypexInfo();
            ty.ShowDialog();
        }

        private void buttonSifre_Click(object sender, EventArgs e)
        {
            TypexSifra tsifra = new TypexSifra();
            tsifra.ShowDialog();
        }

        private void buttonScripta_Click(object sender, EventArgs e)
        {
            TypexSkriptacs skripta = new TypexSkriptacs();
            skripta.ShowDialog();
        }

        private void buttonZnakovi_Click(object sender, EventArgs e)
        {
            TypexSlike slike = new TypexSlike();
            slike.ShowDialog();
        }
    }
}
