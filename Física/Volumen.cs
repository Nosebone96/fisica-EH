namespace física_EH
{
    public partial class Volumen : Form
    {
        public Volumen()
        {
            InitializeComponent();
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCubos_Click(object sender, EventArgs e)
        {
            double vc = double.Parse(txtLadoCubo.Text);
            double VolumenCubo = Math.Pow(vc, 3);
            lblVolumenCubo.Text = "" + VolumenCubo;
        }

        private void BtnLimpiarCubo_Click(object sender, EventArgs e)
        {
            lblVolumenCubo.Text = "";
            txtLadoCubo.Text = "";
        }

        private void BtnCalcularEsfera_Click(object sender, EventArgs e)
        {
            double rs = double.Parse(txtRadioEsfera.Text);
            double ves = (4 * Math.PI * Math.Pow(rs, 3) / 3);
            lblVolumenEsfera.Text = "" + ves;
        }

        private void BtnLimpiarEsfera_Click(object sender, EventArgs e)
        {
            txtRadioEsfera.Text = "";
            lblVolumenEsfera.Text = "";
        }

        private void BtnCalcularCilindro_Click(object sender, EventArgs e)
        {
            double ac = double.Parse(txtAlturaCilindro.Text);
            double rcn = double.Parse(txtRadioCilindro.Text);
            double vcn = (Math.PI * Math.Pow(rcn, 2)) * ac;
            LblVolumenCilindro.Text = "" + vcn;
        }

        private void BtnLimpiarCilindro_Click(object sender, EventArgs e)
        {
            txtRadioCilindro.Text = "";
            txtAlturaCilindro.Text = "";
            LblVolumenCilindro.Text = "";
        }
    }
}
