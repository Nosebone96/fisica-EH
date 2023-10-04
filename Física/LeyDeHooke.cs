using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace física_EH
{
    public partial class LeyDeHooke : Form
    {
        public LeyDeHooke()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(TxtConstanteDeRigidez.Text, out double constantederigidez);
            _ = Double.TryParse(TxtDeformaciónResorte.Text, out double deformacionresorte);
            _ = Double.TryParse(TxtFuerza.Text, out double fuerza);

            if (TxtFuerza.Text == "")
            {
                fuerza = constantederigidez * deformacionresorte;
                goto final;
            }

            if (TxtDeformaciónResorte.Text == "")
            {
                deformacionresorte = fuerza / constantederigidez;
                goto final;
            }

            if (TxtConstanteDeRigidez.Text == "")
            {
                constantederigidez = fuerza / deformacionresorte;
                goto final;
            }


final:;

            int indice = 0;
            if (string.IsNullOrEmpty(TxtFuerza.Text)) { indice++; }
            if (string.IsNullOrEmpty(TxtDeformaciónResorte.Text)) { indice++; }
            if (string.IsNullOrEmpty(TxtConstanteDeRigidez.Text)) { indice++; }
            if (indice >= 2)
            {
                MessageBox.Show("Los datos digitados son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fuerza = 0;
                constantederigidez = 0;
                deformacionresorte = 0;
            }
            TxtConstanteDeRigidez.Text = "" + constantederigidez;
            TxtDeformaciónResorte.Text = "" + deformacionresorte;
            TxtFuerza.Text = "" + fuerza;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtFuerza.Text = "";
            TxtDeformaciónResorte.Text = "";
            TxtConstanteDeRigidez.Text = "";
        }

        private void TxtFuerza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
