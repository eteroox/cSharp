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
    public partial class SigabaInfo : Form
    {
        public SigabaInfo()
        {
            InitializeComponent();
            labelPravila.MaximumSize = new Size(650, 0);
        }

        private void SigabaInfo_Load(object sender, EventArgs e)
        {
            using (var context = new uredajiEntities1())
            {
                var textPravila = context.pravilas
                                        .Where(b => b.id == 2);
                foreach (var rezultat in textPravila)
                {
                    labelPravila.Text = rezultat.pravilo;
                }
            }
        }
    }
}
