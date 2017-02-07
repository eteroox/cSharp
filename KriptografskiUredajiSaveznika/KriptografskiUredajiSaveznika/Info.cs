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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            labelText.MaximumSize = new Size(640, 0);
        }

        private void Info_Load(object sender, EventArgs e)
        {
            using (var context = new uredajiEntities1())
            {
                var opis = context.pravilas
                                   .Where(b => b.id == 3);

                foreach(var rezultat in opis)
                {
                    labelText.Text = rezultat.opis;
                }
            }
        }
    }
}
