using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace física_EH
{
    public partial class Electrónica : Form
    {
        public Electrónica()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        #region Calcular Resistencia
        class Franjas
        {
            public int Franja1 { get; set; }
            public int Franja2 { get; set; }
            public int Franja3 { get; set; }
            public int Franja4 { get; set; }
            public int Franja5 { get; set; }

        }
        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
        private void BtnCalcularRTeorica_Click(object sender, EventArgs e)
        {
            Franjas franja = new()
            {
                Franja1 = CbColorFranja1.SelectedIndex,
                Franja2 = CbColorFranja2.SelectedIndex,
                Franja3 = CbColorFranja3.SelectedIndex,
                Franja4 = ColorFranja4.SelectedIndex
            };

            int ValorNormal;
            if (franja.Franja3 == 0)
            {
                ValorNormal = franja.Franja1 * 10 + franja.Franja2;
                LblValorNormal.Text += "" + ValorNormal + "Ω";

            }
            else
            {
                ValorNormal = (franja.Franja1 * 10 + franja.Franja2) * (int)Math.Pow(10, franja.Franja3);
                LblValorNormal.Text += "" + ValorNormal + "Ω";
            }
            double PorcentajeTolerancia = 0;
            if (franja.Franja4 == 0)
            {
                LblValorRealR.Text += (ValorNormal * 0.95) + " a " + (ValorNormal * 1.05) + "Ω";
                PorcentajeTolerancia = 5;
            }
            else if (franja.Franja4 == 1)
            {
                LblValorRealR.Text += (ValorNormal * 0.9) + "Ω" + " a " + (ValorNormal * 1.1) + "Ω";
                PorcentajeTolerancia = 10;
            }
            else if (franja.Franja4 == 2)
            {
                LblValorRealR.Text += (ValorNormal * 0.98) + "Ω" + " a " + (ValorNormal * 1.02) + "Ω";
                PorcentajeTolerancia = 2;
            }
            else if (franja.Franja4 == 3)
            {
                LblValorRealR.Text += (ValorNormal * 0.99) + "Ω" + " a " + (ValorNormal * 1.01) + "Ω";
                PorcentajeTolerancia = 1;
            }
            else if (franja.Franja4 == 4)
            {
                LblValorRealR.Text += (ValorNormal * 0.995) + "Ω" + " a " + (ValorNormal * 1.005) + "Ω";
                PorcentajeTolerancia = 0.5;
            }
            else if (franja.Franja4 == 5)
            {
                LblValorRealR.Text += (ValorNormal * 0.9975) + "Ω" + " a " + (ValorNormal * 1.0025) + "Ω";
                PorcentajeTolerancia = 0.25;
            }
            else if (franja.Franja4 == 6)
            {
                LblValorRealR.Text += (ValorNormal * 0.999) + "Ω" + " a " + (ValorNormal * 1.001) + "Ω";
                PorcentajeTolerancia = 0.1;
            }
            else if (franja.Franja4 == 7)
            {
                LblValorRealR.Text += (ValorNormal * 0.9995) + "Ω" + " a " + (ValorNormal * 1.0005) + "Ω";
                PorcentajeTolerancia = 0.05;
            }
            else if (franja.Franja4 == 8)
            {
                LblValorRealR.Text += (ValorNormal * 0.8) + "Ω" + " a " + (ValorNormal * 1.2) + "Ω";
                PorcentajeTolerancia = 20;
            }
            double ValorTolerancia = ValorNormal * (PorcentajeTolerancia / 100);
            LblTolerancia.Text += " " + ValorTolerancia.ToString() + "Ω";
            BtnCalcularRTeorica.Enabled = false;
            BtnLimpiarResistencia.Enabled = true;
        }

        private void BtnLimpiarResistencia_Click(object sender, EventArgs e)
        {
            CbColorFranja1.SelectedIndex = -1;
            CbColorFranja2.SelectedIndex = -1;
            CbColorFranja3.SelectedIndex = -1;
            ColorFranja4.SelectedIndex = -1;
            LblValorNormal.Text = "El valor Normal o teórico es: ";
            LblValorRealR.Text = "El valor real ronda entre: ";
            LblTolerancia.Text = "El valor de la tolerancia es de:";
            BtnCalcularRTeorica.Enabled = true;
            BtnLimpiarResistencia.Enabled = false;
        }
        #endregion
        #region Ley de Ohm
        private void TabPage2_Click(object sender, EventArgs e)
        {

        }
        private void BtnCalcularOhm_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(TxtCorrienteOhm.Text, out double CorrienteOhm);
            _ = Double.TryParse(TxtResistenciaOhm.Text, out double ResistenciaOhm);
            _ = Double.TryParse(TxtVoltageOhm.Text, out double VoltageOhm);
            if (TxtVoltageOhm.Text == "")
            {
                VoltageOhm = CorrienteOhm * ResistenciaOhm;
            }
            else if (TxtCorrienteOhm.Text == "")
            {
                CorrienteOhm = VoltageOhm / ResistenciaOhm;
            }
            else if (TxtResistenciaOhm.Text == "")
            {
                ResistenciaOhm = VoltageOhm / CorrienteOhm;
            }
            if ((TxtCorrienteOhm.Text != "" && (TxtResistenciaOhm.Text == "" && TxtVoltageOhm.Text == "")) ||
                    (TxtResistenciaOhm.Text != "" && (TxtCorrienteOhm.Text == "" && TxtVoltageOhm.Text == "")) ||
                    (TxtVoltageOhm.Text != "" && (TxtCorrienteOhm.Text == "" && TxtResistenciaOhm.Text == "")))
            {
                MessageBox.Show("Los datos digitados son incorrectos", "Error");
                VoltageOhm = 0;
                CorrienteOhm = 0;
                ResistenciaOhm = 0;
            }
            TxtVoltageOhm.Text = "" + VoltageOhm;
            TxtResistenciaOhm.Text = "" + ResistenciaOhm;
            TxtCorrienteOhm.Text = "" + CorrienteOhm;
            BtnCalcularOhm.Enabled = false;
            BtnLimpiarOhm.Enabled = true;
        }
        private void BtnLimpiarOhm_Click(object sender, EventArgs e)
        {
            TxtVoltageOhm.Text = "";
            TxtResistenciaOhm.Text = "";
            TxtCorrienteOhm.Text = "";
            BtnCalcularOhm.Enabled = true;
            BtnLimpiarOhm.Enabled = false;
        }
        #endregion



    }
}
