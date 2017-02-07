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
    public partial class TypexSifra : Form
    {
        public TypexSifra()
        {
            InitializeComponent();
        }

        private void TypexSifra_Load(object sender, EventArgs e)
        {
            using (var context = new uredajiEntities1())
            {
                var slovaSifre = context.typexes;

                foreach(var rezultat in slovaSifre)
                {
                    dataGridView1.Rows.Add(rezultat.slovo,rezultat.sifra);
                }
            }
        }
    }
}
