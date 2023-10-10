using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace física_EH
{
    public partial class Matemáticas : Form
    {

        public Matemáticas()
        {
            InitializeComponent();
        }
        private double LadoA;
        private double LadoB;
        private double LadoC;
        private double AnguloA;
        private double AnguloB;
        private double AnguloC;
        private int lados;
        private int angulos;
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int textBoxesConDatosValidos = 0;
            if (!string.IsNullOrWhiteSpace(TxtLadoa.Text) && Double.TryParse(TxtLadoa.Text, out LadoA)) { textBoxesConDatosValidos++; }
            if (!string.IsNullOrWhiteSpace(TxtLadob.Text) && Double.TryParse(TxtLadob.Text, out LadoB)) { textBoxesConDatosValidos++; }
            if (!string.IsNullOrWhiteSpace(TxtLadoc.Text) && Double.TryParse(TxtLadoc.Text, out LadoC)) { textBoxesConDatosValidos++; }
            if (!string.IsNullOrWhiteSpace(TxtánguloA.Text) && Double.TryParse(TxtánguloA.Text, out AnguloA)) { textBoxesConDatosValidos++; }
            if (!string.IsNullOrWhiteSpace(TxtánguloB.Text) && Double.TryParse(TxtánguloB.Text, out AnguloB)) { textBoxesConDatosValidos++; }
            if (!string.IsNullOrWhiteSpace(TxtángulC.Text) && Double.TryParse(TxtángulC.Text, out AnguloC)) { textBoxesConDatosValidos++; }
            if (textBoxesConDatosValidos < 3)
            {
                MessageBox.Show("Al menos tres campos deben contener datos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (AnguloA != 0) { angulos++; }
            if (AnguloB != 0) { angulos++; }
            if (AnguloC != 0) { angulos++; }
            if (LadoA != 0) { lados++; }
            if (LadoB != 0) { lados++; }
            if (LadoC != 0) { lados++; }
            int cantidad = 0;
            while (LadoA == 0 || LadoB == 0 || LadoC == 0 || AnguloA == 0 || AnguloB == 0 || AnguloC == 0)
            {
                if (
                    (LadoA != 0 && LadoB != 0 && AnguloC != 0 && LadoC == 0) ||
                    (LadoB != 0 && LadoC != 0 && AnguloA != 0 && LadoA == 0) ||
                    (LadoA != 0 && LadoC != 0 && AnguloB != 0 && LadoB == 0))
                {
                    LeyCosenoALL();
                }
                else if ((LadoA != 0 && LadoB != 0 && (AnguloA != 0 || AnguloB != 0) ||
                         (LadoB != 0 && LadoC != 0 && (AnguloB != 0 || AnguloC != 0)) ||
                         (LadoC != 0 && LadoA != 0 && (AnguloC != 0 || AnguloA != 0))))
                {
                    LeyDelSenoLLA();
                }
                else if (angulos <= 2 && lados >= 1)
                {
                    LeyDelSenoALA();
                }
                if (lados <= 3 && angulos < 3)
                {
                    LeyDelCosenoLLL();
                }
                if (AnguloA != 0 && AnguloB != 0 && AnguloC != 0)
                {
                    if ((AnguloA + AnguloB + AnguloC) != 180)
                    {
                        return;
                    }
                }
                cantidad++;
                if (cantidad >= 10)
                {
                    MessageBox.Show("No se puede resolver el triángulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            LadoA = Math.Round(LadoA, 2);
            LadoB = Math.Round(LadoB, 2);
            LadoC = Math.Round(LadoC, 2);
            AnguloA = Math.Round(AnguloA, 2);
            AnguloB = Math.Round(AnguloB, 2);
            AnguloC = Math.Round(AnguloC, 2);
            TxtLadoa.Text = "" + LadoA;
            TxtLadob.Text = "" + LadoB;
            TxtLadoc.Text = "" + LadoC;
            TxtánguloA.Text = "" + AnguloA;
            TxtánguloB.Text = "" + AnguloB;
            TxtángulC.Text = "" + AnguloC;
        }
        private void AnguloFaltante()
        {
            if (AnguloA == 0)
            {
                AnguloA = 180 - AnguloB - AnguloC;
                angulos++;

            }
            else if (AnguloB == 0)
            {
                AnguloB = 180 - AnguloA - AnguloC;
                angulos++;
            }
            else if (AnguloC == 0)
            {
                AnguloC = 180 - AnguloA + AnguloB;
                angulos++;
            }
        }
        private void LeyDelSenoALA()
        {
            AnguloFaltante();
            if (LadoA != 0)
            {
                if (LadoB == 0)
                {
                    LadoB = (LadoA * Math.Sin(AnguloB)) / Math.Sin(AnguloA);
                    lados++;
                }
                if (LadoC == 0)
                {
                    LadoC = (LadoA * Math.Sin(AnguloC)) / Math.Sin(AnguloA);
                    lados++;
                }

            }
            if (LadoB != 0)
            {
                if (LadoA == 0)
                {
                    LadoA = (LadoB * Math.Sin(AnguloA)) / Math.Sin(AnguloB);
                    lados++;
                }
                if (LadoC == 0)
                {
                    LadoC = (LadoB * Math.Sin(AnguloC)) / Math.Sin(AnguloB);
                    lados++;
                }
            }
            if (LadoC != 0)
            {
                if (LadoA == 0)
                {
                    LadoA = (LadoC * Math.Sin(AnguloA)) / Math.Sin(AnguloC);
                    lados++;
                }
                if (LadoB == 0)
                {
                    LadoB = (LadoC * Math.Sin(AnguloB) / Math.Sin(AnguloC));
                    lados++;
                }
            }

        }
        private void LeyDelSenoLLA()
        {
            if (LadoA == 0)
            {
                if (AnguloB == 0)
                {
                    AnguloB = Math.Asin(LadoB * Math.Sin(AnguloC * Math.PI / 180.0) / LadoC);
                    AnguloB *= (180.0 / Math.PI);
                    angulos++;
                }
                else if (AnguloC == 0)
                {
                    AnguloC = Math.Asin((Math.Sin(AnguloB * Math.PI / 180.0) * LadoC / LadoB));
                    AnguloC *= (180.0 / Math.PI);
                    angulos++;
                }
                AnguloFaltante();
            }
            if (LadoB == 0)
            {
                if (AnguloA == 0)
                {
                    AnguloA = Math.Asin((Math.Sin(AnguloC * Math.PI / 180.0) * LadoA / LadoC));
                    AnguloA *= (180.0 / Math.PI);
                    angulos++;
                }
                else if (AnguloC == 0)
                {
                    AnguloC = Math.Asin((Math.Sin(AnguloA * Math.PI / 180.0) * LadoC / LadoA));
                    AnguloC *= (180.0 / Math.PI);
                    angulos++;
                }
                AnguloFaltante();
            }
            if (LadoC == 0)
            {
                if (AnguloA == 0)
                {
                    AnguloA = Math.Asin((LadoA * Math.Sin(AnguloB * Math.PI / 180.0) / LadoB));
                    AnguloA *= (180.0 / Math.PI);
                    angulos++;
                }
                else if (AnguloB == 0)
                {
                    AnguloB = Math.Asin((LadoB * Math.Sin(AnguloA * Math.PI / 180.0) / LadoA));
                    AnguloB *= (180.0 / Math.PI);
                    angulos++;
                }
                AnguloFaltante();
            }
        }
        private void LeyDelCosenoLLL()
        {
            if (AnguloA == 0)
            {
                AnguloA = Math.Acos((Math.Pow(LadoA, 2) - Math.Pow(LadoB, 2) - Math.Pow(LadoC, 2)) / (-2.0 * LadoB * LadoC));
                AnguloA *= Math.PI / 180.0;
                angulos++;
            }
            if (AnguloB == 0)
            {
                AnguloB = Math.Acos((Math.Pow(LadoB, 2) - Math.Pow(LadoA, 2) - Math.Pow(LadoC, 2)) / (-2.0 * LadoA * LadoC));
                AnguloB *= Math.PI / 180.0;
                angulos++;
            }
            if (AnguloC == 0)
            {
                AnguloC = Math.Acos((Math.Pow(LadoC, 2) - Math.Pow(LadoA, 2) - Math.Pow(LadoB, 2)) / (-2.0 * LadoA * LadoB));
                AnguloC *= Math.PI / 180.0;
                angulos++;
            }
        }
        private void LeyCosenoALL()
        {
            if (LadoA == 0)
            {
                LadoA = Math.Sqrt(Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2) - 2 * LadoB * LadoC * Math.Cos(Math.PI * AnguloA / 180.0));
                lados++;
            }
            if (LadoB == 0)
            {
                LadoB = Math.Sqrt(Math.Pow(LadoA, 2) + Math.Pow(LadoC, 2) - 2 * LadoA * LadoC * Math.Cos(Math.PI * AnguloB / 180.0));
                lados++;
            }
            if (LadoC == 0)
            {
                LadoC = Math.Sqrt(Math.Pow(LadoB, 2) + Math.Pow(LadoA, 2) - 2 * LadoB * LadoA * Math.Cos(Math.PI * AnguloC / 180.0));
                lados++;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtLadoa.Text = "";
            TxtLadob.Text = "";
            TxtLadoc.Text = "";
            TxtánguloA.Text = "";
            TxtánguloB.Text = "";
            TxtángulC.Text = "";
        }
    }
}
