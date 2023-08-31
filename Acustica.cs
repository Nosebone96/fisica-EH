using Microsoft.VisualBasic;
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
    public partial class Acustica : Form
    {
        public Acustica()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        //velocidad del sonido
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(Txtdensidadpropagacion.Text, out double densidadpropagacion);
            _ = Double.TryParse(Txtelasticidadpropagacion.Text, out double elasticidadpropagacion);
            double velociadpropagacion = Math.Sqrt(elasticidadpropagacion / densidadpropagacion);
            Lblvelocidaddelsonido.Text = "" + velociadpropagacion + "m/s";
        }
        private void BtnLimpiarDs_Click(object sender, EventArgs e)
        {
            Txtdensidadpropagacion.Text = "";
            Txtelasticidadpropagacion.Text = "";
            Lblvelocidaddelsonido.Text = "";
        }
        //Longitud de onda
        private void BtnCalcularOnda_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(TxtDespalazamientosonidolo.Text, out double desplazaminetolongitudonda);
            _ = Double.TryParse(TxtFrecuenciaLo.Text, out double FrencuenciaLO);
            double Longitudonda = desplazaminetolongitudonda / FrencuenciaLO;
            Lbllongitudonda.Text = "" + Longitudonda + "λ";
        }
        private void BtnLimpiarLongitudOnda_Click(object sender, EventArgs e)
        {
            TxtDespalazamientosonidolo.Text = "";
            TxtFrecuenciaLo.Text = "";
            Lbllongitudonda.Text = "";
        }
        //Frecuencia
        private void BtnFrecuenciaAcustica_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(TxtDesplazamientosfrecuencia.Text, out double desplazamientofrecuencia);
            _ = Double.TryParse(TxtLongitudondafrecuencia.Text, out double Longitudondafrecuencia);
            double Frecuencia = desplazamientofrecuencia / Longitudondafrecuencia;
            Lblfrecuenciaonda.Text = "" + Frecuencia + "Hz";
        }
        private void BtnLimpiarFrecuencia_Click(object sender, EventArgs e)
        {
            TxtDesplazamientosfrecuencia.Text = "";
            TxtLongitudondafrecuencia.Text = "";
            Lblfrecuenciaonda.Text = "";
        }


        private void TabPage4_Click(object sender, EventArgs e)
        {

        }
        //Presión sonora
        private void BtnNPS_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(TxtPS.Text, out double presionsonora);
            _ = Double.TryParse(TxtPR.Text, out double presionreferencia);
            double NPS = 20 * (Math.Log10(presionsonora / presionreferencia));
            LblNPS.Text = "" + NPS + "dB";
        }
        private void BtnLimPresuonSonora_Click(object sender, EventArgs e)
        {
            TxtPS.Text = "";
            TxtPR.Text = "";
            LblNPS.Text = "";
        }
        //nivel intensidad sonora

        private void BtnNIS_Click(object sender, EventArgs e)
        {
            const double intencidadReferencia = 0.000000000001;
            _ = Double.TryParse(Txtintensidadsonora.Text, out double intensidadSonora);
            double nis = 10 * Math.Log10(intensidadSonora / intencidadReferencia);
            LblNIS.Text = "" + nis + "dB";
        }
        private void BnLimNis_Click(object sender, EventArgs e)
        {
            Txtintensidadsonora.Text = "";
            LblNIS.Text = "";
        }
        //ley de propagación de sonido en el aire
        private void BtnLPN_Click(object sender, EventArgs e)
        {
            const double R = 8.314;
            _ = Double.TryParse(TxtCAD.Text, out double CAD);
            _ = Double.TryParse(TxtTkelvin.Text, out double kelvin);
            double V = Math.Sqrt(CAD * R * kelvin);
            LblrptaL.Text = "" + V + " m/s";
        }
        private void BnLimLPSA_Click(object sender, EventArgs e)
        {
            TxtCAD.Text = "";
            TxtTkelvin.Text = "";
            LblrptaL.Text = "";
        }
        //Ley de Doppler
        private void BtnDoppler_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(TxtfrecuenciaD.Text, out double frecuenciaD);
            _ = Double.TryParse(TxtVSO.Text, out double VSO);
            _ = Double.TryParse(TxtVO.Text, out double VO);
            _ = Double.TryParse(TxtVF.Text, out double VF);
            double D = frecuenciaD * (VSO + VO) / (VSO + VF);
            LblDoppler.Text = "" + D + " Hz";
        }

        private void BtnLimDoppler_Click(object sender, EventArgs e)
        {
            TxtfrecuenciaD.Text = "";
            TxtVSO.Text = "";
            TxtVO.Text = "";
            TxtVF.Text = "";
            LblDoppler.Text = "";
        }
    }
}

