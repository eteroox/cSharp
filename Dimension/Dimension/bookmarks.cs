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
    public partial class bookmarks : Form
    {
        public bookmarks()
        {
            InitializeComponent();
        }

        //sto se dogada kad se forma loada
        private void bookmarks_Load(object sender, EventArgs e)
        {
            textBoxBookmark.Text = MainForm.tekst;              //text koji je napisan u textboxu iz main forme 
            System.Xml.XmlDocument loadDoc = new System.Xml.XmlDocument();          //loada storane bookmarkse
            loadDoc.Load(Application.StartupPath + "\\bookmarks.xml");
            foreach (System.Xml.XmlNode favNode in loadDoc.SelectNodes("/bookmarks/Item"))
            {
                listViewBookmark.Items.Add(favNode.Attributes["url"].InnerText);
            }
        }

        //za prelazak u main formu i prikazivanje odabranog linka
        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                tekst2 = listViewBookmark.SelectedItems[0].SubItems[0].Text;
                MainForm.tekst = tekst2;
                this.Close();
            }
            catch
            {
                MessageBox.Show("You need to select an item");
            }
        }

        //za prikazivanje unutar main forme na dupli click
        public static string tekst2;
        private void listViewBookmark_DoubleClick(object sender, EventArgs e)
        {
            //tekst2 = listViewBookmark.SelectedIndices[0].ToString();
            tekst2 = listViewBookmark.SelectedItems[0].SubItems[0].Text;
            MainForm.tekst = tekst2;
            this.Close();

        }

        //za dodavanje u listview
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listViewBookmark.Items.Add(new ListViewItem(textBoxBookmark.Text));
        }

        //remove
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listViewBookmark.Items.RemoveAt(listViewBookmark.SelectedIndices[0]);
            }
            catch
            {
                MessageBox.Show("You need to select an item");
            }
        }

        //na enter da se dodaje u listu
        private void textBoxBookmark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                listViewBookmark.Items.Add(new ListViewItem(textBoxBookmark.Text));
            }
        }

        private void bookmarks_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Xml.XmlTextWriter writer = new
            System.Xml.XmlTextWriter(Application.StartupPath + "\\bookmarks.xml", null);
            writer.WriteStartElement("bookmarks");
            for (int i = 0; i < listViewBookmark.Items.Count; i++)
            {
                writer.WriteStartElement("Item");
                writer.WriteAttributeString("url", listViewBookmark.Items[i].Text);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }

    }
}
