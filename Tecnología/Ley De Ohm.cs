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
    public partial class Ley_De_Ohm : Form
    {
        public Ley_De_Ohm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
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
            int indice = 0;
            if (string.IsNullOrEmpty(TxtCorrienteOhm.Text)) { indice++; }
            if (string.IsNullOrEmpty(TxtResistenciaOhm.Text)) { indice++; }
            if (string.IsNullOrEmpty(TxtVoltageOhm.Text)) { indice++; }
            if (indice >= 2)
            {
                MessageBox.Show("Los datos digitados son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CorrienteOhm = 0;
                ResistenciaOhm = 0;
                VoltageOhm = 0;
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
    }
}
