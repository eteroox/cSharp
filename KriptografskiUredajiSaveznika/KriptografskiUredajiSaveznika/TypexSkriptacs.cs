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
    public partial class TypexSkriptacs : Form
    {
        public TypexSkriptacs()
        {
            InitializeComponent();
            labelSkripta.MaximumSize = new Size(545, 0);
        }

        private void TypexSkriptacs_Load(object sender, EventArgs e)
        {
            using (var context = new uredajiEntities1())
            {
                var opis = context.pravilas
                                   .Where(b => b.id == 1);

                foreach (var result in opis)
                {
                    labelSkripta.Text = result.opis;
                }
            }
        }
    }
}
