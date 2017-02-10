using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaverMatrix
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private int xPosition0 = Cursor.Position.X;
        private int yPosition0 = Cursor.Position.Y;


        string[] brojeviIslova = new[] { "0"," ", "1", "2"," ", "3"," ", "4", "5", "6", "7"," ", " ", "8", "9", " ", "A", " ", "B", "C"," ", " ", "D", "E", "F", " " };

        private void Form1_Load(object sender, EventArgs e)
        {
            generateMyData();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 200;
            timer.Start();
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (xPosition0 - Cursor.Position.X < -10
                || yPosition0 - Cursor.Position.Y < -10)
            {
                this.Close();
            }
        }


        public void generateMyData()
        {
            richTextBox1.Text = "";
            Form1 forma = new Form1();
            Random random = new Random();

            int width = forma.Width;
            int height = forma.Height;
            var y = new int[width];

            while (richTextBox1.TextLength < height + width + richTextBox1.Height)
            {
                int start = random.Next(0, brojeviIslova.Length);

                int length = richTextBox1.TextLength;
                richTextBox1.AppendText(brojeviIslova[start]);



                if (start > 6)
                {
                    richTextBox1.SelectionStart = length;
                    richTextBox1.SelectionLength = brojeviIslova[start].Length;
                    richTextBox1.SelectionColor = Color.FromArgb(0, 192, 0);
                }
                else
                {
                    richTextBox1.SelectionStart = length;
                    richTextBox1.SelectionLength = brojeviIslova[start].Length;
                    richTextBox1.SelectionColor = Color.White;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            generateMyData();
        }
    }
}
