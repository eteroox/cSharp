using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        //metoda za funkciju buttona

        private void bttnFunkcija(object sender, EventArgs e)
        {
            if (tBoxDisplay.Text != "0")
                tBoxDisplay.Text += ((Button)sender).Text;
            else tBoxDisplay.Text = ((Button)sender).Text;
        }

        //metoda za backspace

        private void bttnBackSpace_Click(object sender, EventArgs e)
        {
            tBoxDisplay.Text = tBoxDisplay.Text.Remove(tBoxDisplay.Text.Length - 1);
            if (tBoxDisplay.Text.Length == 0 || tBoxDisplay.Text ==",")
                tBoxDisplay.Text = "0";

        }
        
        //metoda za decimalnu tocku

        private void bttnDecTocka_Click(object sender, EventArgs e)
        {
            if(tBoxDisplay.Text.Contains(',') ==false)
            tBoxDisplay.Text += ",";
        }

        //metoda za predznak

        private void bttnPreznak_Click(object sender, EventArgs e)
        {
            if (tBoxDisplay.Text.Contains("-"))
                tBoxDisplay.Text = tBoxDisplay.Text.Remove(0, 1);
            else tBoxDisplay.Text = "-" + tBoxDisplay.Text;
        }


        //shorcati za tipke
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    bttnFunkcija(bttnNum0, new EventArgs());
                    //e.Handled = true;
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    bttnFunkcija(bttnNum1, new EventArgs());
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    bttnFunkcija(bttnNum2, new EventArgs());
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    bttnFunkcija(bttnNum3, new EventArgs());
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    bttnFunkcija(bttnNum3, new EventArgs());
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    bttnFunkcija(bttnNum5, new EventArgs());
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    bttnFunkcija(bttnNum6, new EventArgs());
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    bttnFunkcija(bttnNum7, new EventArgs());
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    bttnFunkcija(bttnNum8, new EventArgs());
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    bttnFunkcija(bttnNum9, new EventArgs());
                    break;
                case Keys.Back:
                    bttnBackSpace_Click(bttnBackSpace, new EventArgs());
                    break;
                case Keys.Decimal:
                case Keys.Oemcomma:
                case Keys.OemPeriod:
                    bttnDecTocka_Click(bttnDecTocka, new EventArgs());
                    break;
                case Keys.Delete:
                    tBoxDisplay.Text = "0";
                    break;

            }
        
        }

        //funkcije za racunanje
        private byte mathOperacija = 0;
        private double operand1, operand2,operand3;
        private bool noviUnos = true, unosOperanda2=false;
        string operacija;

        /*
        private void funkcijeMath(object sender, EventArgs e)
        {
            if (unosOperanda2 == false)
                double.TryParse(tBoxDisplay.Text, out operand1);
            else izracunaj_Click(sender, e);
            switch(((Button)sender).Text)
            {
                case "+":
                    mathOperacija = 1;
                    break;
                case "-":
                    mathOperacija = 2;
                    break;
                case "*":
                    mathOperacija = 3;
                    break;
                case "/":
                    mathOperacija = 4;
                    break;
            }
            noviUnos = true;
            unosOperanda2 = true;
        }

        //funkcija jednako
        
        private void izracunaj_Click(object sender, EventArgs e)
        {
            if (unosOperanda2 == false)
                operand2 = double.Parse(tBoxDisplay.Text);//, out this.operand2);
            switch (mathOperacija)
            {
                    
                case 1:
                    operand3 = operand1 + operand2;
                    break;
                case 2:
                    operand1 = operand1 - operand2;
                    break;
                case 3:
                    operand1 = operand1 * operand2;
                    break;
                case 4:
                    operand1 = operand1 / operand2;
                    break;
            }

            tBoxDisplay.Text = "0";
            tBoxDisplay.Text = operand3.ToString();
            noviUnos = true;
            unosOperanda2 = true;

        }
         * */

        //funkcije za racunanje
        private void buttonOperand_Click(object sender, EventArgs e)
        {
            tBoxDisplay.Focus();
            if (unosOperanda2 == false)
            {
                double.TryParse(tBoxDisplay.Text, out operand1);
            }
            else
            {
                bttnIzracunaj.PerformClick();
            }

            operacija = ((Button)sender).Text;

            tBoxDisplay.Clear();

            unosOperanda2 = true;
        }

        //funkcija jednako
        private void izracunaj_Click(object sender, EventArgs e)
        {
            tBoxDisplay.Focus();
            operand3 = operand1;

            double.TryParse(tBoxDisplay.Text, out operand2);

            switch (operacija)
            {
                case "+":
                    operand1 = operand1 + operand2;
                    break;
                case "-":
                    operand1 = operand1 - operand2;
                    break;
                case "*":
                    operand1 = operand1 * operand2;
                    break;
                case "/":
                    operand1 = operand1 / operand2;
                    break;
            }
            textBoxOperacije.Text = operand3 + " " + operacija + " " + operand2;

            tBoxDisplay.Text = operand1.ToString();

            unosOperanda2 = false;
        }

        // tipka ce
        private void bttnCE_Click(object sender, EventArgs e)
        {
            tBoxDisplay.Text = "0";
        }

        // tipka c
        private void bttnC_Click(object sender, EventArgs e)
        {
            tBoxDisplay.Text = "0";
            textBoxOperacije.Text = "0";
            operand1 = operand2 = 0;
        }

        //hover na tipke
        private void bttn_MouseEnter(object sender, EventArgs e)
        {
            bttnDecTocka.BackColor = Color.PaleGreen;
        }

        private void bttn_MouseLeave(object sender, EventArgs e)
        {
            bttnDecTocka.BackColor = SystemColors.Control;
        }

        //za menustrip
        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            standardToolStripMenuItem.Visible = true;
            scientificToolStripMenuItem.Visible = true;
            programmerToolStripMenuItem.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }


    }
}
