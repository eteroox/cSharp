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
    public partial class TypexSlike : Form
    {
        public TypexSlike()
        {
            InitializeComponent();
            labelKrave.MaximumSize = new Size(400, 0);
            labelVrapci.MaximumSize = new Size(400, 0);
            labelPsi.MaximumSize = new Size(400, 0);
            labelMacke.MaximumSize = new Size(400, 0);
        }

        private void TypexSlike_Load(object sender, EventArgs e)
        {
            labelKrave.Text = "Prvi rotor se nalazi na poziciji koju tvore prve dvije znamenke godine nastanka Typexa. Pozicije za druga dva rotora su po jedna od znamenaka koje tvore model typexa koji se koristio za komunikaciju sa Amerikancima ( prva znamenka na prvi , druga na drugi ). ";
            labelVrapci.Text = "Prvi rotor je na poziciji broja modela typexa koji je omogucio komunikaciju izmedu Amerikanaca i Britanaca. Druga dva rotora su brojojevi koji tvore ukupan broj slova na kotacima rotora Typexa (prva znamenka prvi , druga znamenka drugi) ";
            labelPsi.Text = " Pozicija prvog rotora je broj zivotinja na slici. Pozicija drugog rotora je prvi broj koji se pojavljuje u tekstu na glavnom ekranu, a treceg drugi broj";
            labelMacke.Text = "Broj pozicije prvog rotora je broj macaka na slici koje su visak. Pozicije za druga dva rotora su po jedna od znamenaka koje tvore model typexa koji se koristio za komunikaciju sa Amerikancima ( prva znamenka na prvi , druga na drugi ). ";
        }
    }
}
