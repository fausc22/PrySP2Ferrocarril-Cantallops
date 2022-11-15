using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySP2Ferrocarril_Cantallops
{
    public partial class frmFerrocarril : Form
    {
        public frmFerrocarril()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Dias;
            Dias = int.Parse(txtDias.Text);
            int km;
            km = int.Parse(txtDistancia.Text);
            int Precio;
            Precio = int.Parse(txtDistancia.Text) * 5;
            




            if (km >= 100 && Dias >= 7)
            {
                Precio = Precio / 2;
                MessageBox.Show("Total = $ " + Precio.ToString());
            }
            else
            {
                MessageBox.Show("Total = $ " + Precio.ToString());
            }
            
            
            
        }
    }
}
