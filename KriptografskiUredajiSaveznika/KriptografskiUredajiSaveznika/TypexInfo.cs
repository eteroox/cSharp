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
    public partial class TypexInfo : Form
    {
        public TypexInfo()
        {
            InitializeComponent();
            labelPravila.MaximumSize = new Size(650, 0);
        }

        private void TypexInfo_Load(object sender, EventArgs e)
        {
            using (var context = new uredajiEntities1())
            {
                var textPravila = context.pravilas
                                        .Where(b => b.id == 1);
                foreach(var rezultat in textPravila)
                {
                    labelPravila.Text = rezultat.pravilo;
                }
            }
        }
    }
}
