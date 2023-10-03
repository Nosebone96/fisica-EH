using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void BtnFuerzaR_Click_1(object sender, EventArgs e)
        {
            _ = Double.TryParse(TxtF1.Text, out double f1);
            _ = Double.TryParse(TxtF2.Text, out double f2);
            _ = Double.TryParse(TxtAg.Text, out double angulo);
            double fr = Math.Sqrt(Math.Pow(f1, 2) + Math.Pow(f2, 2) + 2 * f1 * f2 * Math.Cos(Math.PI * angulo / 180));

            LblFR.Text = "" + fr + "N";
            CbFuerza.Items.Add(fr);
        }

        private void BtnLimpiarFr_Click_1(object sender, EventArgs e)
        {
            TxtAg.Text = "";
            TxtF1.Text = "";
            TxtF2.Text = "";
            LblFR.Text = "";
            CbFuerza.Text = "";
            txtMasa.Text = "";
            TxtAceleración.Text = "";
        }

        private void BtnCalcularTrianguloDeLaFuerza_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(txtMasa.Text, out double masa);
            _ = Double.TryParse(CbFuerza.Text, out double fuerza);
            _ = Double.TryParse(TxtAceleración.Text, out double aceleracion);
            if (TxtAceleración.Text == "")
            {
                aceleracion = fuerza / masa;
                goto final;
            }
            if (CbFuerza.Text == "")
            {
                fuerza = aceleracion * masa;
                goto final;
            }
            if (txtMasa.Text == "")
            {
                masa = fuerza / aceleracion;
            }
final:;
            CbFuerza.Text = "" + fuerza;
            txtMasa.Text = "" + masa;
            TxtAceleración.Text = "" + aceleracion;

            int indice = 0;
            if (string.IsNullOrEmpty(TxtAceleración.Text)) { indice++; }
            if (string.IsNullOrEmpty(CbFuerza.Text)) { indice++; }
            if (string.IsNullOrEmpty(txtMasa.Text)) { indice++; }
            if (indice >= 2)
            {
                MessageBox.Show("Los datos digitados son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMasa.Text = "";
                TxtAceleración.Text = "";
                CbFuerza.Text = "";
            }
        }
    }
}