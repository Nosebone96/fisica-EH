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
    public partial class Resistencia : Form
    {
        public Resistencia()
        {
            InitializeComponent();

        }
        class Franjas
        {
            public int Franja1 { get; set; }
            public int Franja2 { get; set; }
            public int Franja3 { get; set; }
            public int Franja4 { get; set; }
            public int Franja5 { get; set; }

        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            CbColorFranja1.SelectedIndex = -1;
            CbColorFranja2.SelectedIndex = -1;
            CbColorFranja3.SelectedIndex = -1;
            ColorFranja4.SelectedIndex = -1;
            LblValorNormal.Text = "El valor Normal o teórico es: ";
            LblValorRealR.Text = "El valor real ronda entre: ";
            LblTolerancia.Text = "El valor de la tolerancia es de:";
            BtnCalcularRTeorica.Enabled = true;
            BtnLimpiar.Enabled = false;
        }

        private void BtnCalcularRTeorica_Click_1(object sender, EventArgs e)
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
            BtnLimpiar.Enabled = true;
        }
    }
}
