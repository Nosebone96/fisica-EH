using System.CodeDom;

namespace física_EH
{
    public partial class EcuaciónH : System.Windows.Forms.Form
    {
        public EcuaciónH()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void BtnMRU_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(txtTiempo.Text, out double tiempo);
            _ = Double.TryParse(TxtDistancia.Text, out double distancia);
            _ = Double.TryParse(TxtVelocidad.Text, out double velocidad);

            if (txtTiempo.Text == "")
            {
                tiempo = distancia / velocidad;
                goto final;
            }
            if (TxtDistancia.Text == "")
            {
                distancia = velocidad * tiempo;
                goto final;
            }
            if (TxtVelocidad.Text == "")
            {
                velocidad = distancia / tiempo;
            }
final:;
            int indice = 0;
            if (string.IsNullOrEmpty(txtTiempo.Text)) { indice++; }
            if (string.IsNullOrEmpty(TxtDistancia.Text)) { indice++; }
            if (string.IsNullOrEmpty(TxtVelocidad.Text)) { indice++; }
            if (indice >= 2)
            {
                MessageBox.Show("Los datos digitados son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                velocidad = 0;
                tiempo = 0;
                distancia = 0;
            }
            txtTiempo.Text = "" + tiempo;
            TxtDistancia.Text = "" + distancia;
            TxtVelocidad.Text = "" + velocidad;
            BtnMRU.Enabled = false;
            BtnLimpiarMRU.Enabled = true;
        }

        private void EcuaciónH_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpiarMRU_Click(object sender, EventArgs e)
        {
            txtTiempo.Text = "";
            TxtDistancia.Text = "";
            TxtVelocidad.Text = "";
            BtnMRU.Enabled = true;
            BtnLimpiarMRU.Enabled = false;
        }
    }
}
