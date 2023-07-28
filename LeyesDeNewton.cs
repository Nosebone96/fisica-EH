using System;
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
    public partial class LeyesDeNewton : Form
    {
        public LeyesDeNewton()
        {
            InitializeComponent();
        }

        private void BtnCalcularLD_Click(object sender, EventArgs e)
        {
            try
            {
                _ = Double.TryParse(txtAceleraciónDinamica.Text, out double aceleracion);
                _ = Double.TryParse(txtMasaDinamica.Text, out double masa);
                _ = Double.TryParse(txtFuerza.Text, out double fuerza);

                if (txtAceleraciónDinamica.Text == "")
                {
                    aceleracion = fuerza / masa;
                }
                if (txtFuerza.Text == "")
                {
                    fuerza = masa * aceleracion;
                }
                if (txtMasaDinamica.Text == "")
                {
                    masa = fuerza / aceleracion;
                }
                Lblfuerza.Text = "" + fuerza + "N";
                Lblaceleraciondinamica.Text = "" + aceleracion + "M/S";
                Lblmasadinamica.Text = "" + masa + "Kg";
            }
            catch (FormatException)
            {

            }
        }

        private void BtnLimpiarLD_Click(object sender, EventArgs e)
        {
            Lblaceleraciondinamica.Text = "";
            Lblfuerza.Text = "";
            Lblmasadinamica.Text = "";
            txtAceleraciónDinamica.Text = "";
            txtFuerza.Text = "";
            txtMasaDinamica.Text = "";
        }
    }
}
