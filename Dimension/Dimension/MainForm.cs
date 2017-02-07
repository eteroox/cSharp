using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimension
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// nova verzija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //za bookmarke
        /*
        public string mojText
        {
            get { return textBox1.Text; }
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            navigateToPage();
        }

        //funkcija za search
        private void navigateToPage()
        {
            toolStripStatusLabel1.Text = "Loading";
            textBox1.Enabled = false;
            button1.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);
        }

        //traži na pritisak entera
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)ConsoleKey.Enter)
            {
                navigateToPage();
            }
        }

        //zaključavanje textboxa i buttona pri searchu
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
            toolStripStatusLabel1.Text = "Page loaded";
        }

        //progress bar
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                
                int percentage =  (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                
                if( percentage <= 100)
                {
                    toolStripProgressBar1.ProgressBar.Value = percentage;
                }
            }
            else
            {
                toolStripProgressBar1.ProgressBar.Value = 0;
            }
           while (toolStripProgressBar1.ProgressBar.Value == 0)
           {
               toolStripStatusLabel1.Text = "Page loaded";
               break;
           }
        }
       

        //Refresh gumb
        private void refreshButton_Click(object sender, EventArgs e)
        {
            if(!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }

        //back button
        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        //disejblan je na pocetku kad se nema gdje vratiti
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            backButton.Enabled = webBrowser1.CanGoBack;
        }

        //forward button
        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        //disejbla forward na kraju navigacije
        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            forwardButton.Enabled = webBrowser1.CanGoForward;
        }

        //homepage Button
        private void homePageButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        //facebook
        private void toolStripButtonFacebook_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri("http://facebook.com"));
        }

        //twitter
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri("http://twitter.com"));
        }

        //gmail
        private void toolStripButtonGmail_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri("http://gmail.com"));
        }

        //youtube
        private void toolStripButtonYoutube_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri("http://youtube.com"));
        }

        //tvz
        private void toolStripButtonMojTvz_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri("http://moj.tvz.hr/"));
        }

        //za bookmarks formu
        public static string tekst;
        private void buttonBookmark_Click(object sender, EventArgs e)
        {
            tekst = textBox1.Text;
            bookmarks book = new bookmarks();
            book.Owner = this;
            book.ShowDialog();
            textBox1.Text = tekst;
            webBrowser1.Navigate(textBox1.Text);
        }

    }
}
