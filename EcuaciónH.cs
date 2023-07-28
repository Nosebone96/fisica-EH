using System.CodeDom;

namespace física_EH
{
    public partial class EcuaciónH : System.Windows.Forms.Form
    {
        public EcuaciónH()
        {
            InitializeComponent();
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
            lblDistancia.Text = "La distancia es: " + distancia + "m";
            lblVelociad.Text = "La velocidad es: " + velocidad + "m/s";
            LblTiempo.Text = "El tiempo es: " + tiempo + "s";
        }

        private void EcuaciónH_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpiarMRU_Click(object sender, EventArgs e)
        {
            lblDistancia.Text = "";
            lblVelociad.Text = "";
            LblTiempo.Text = "";
            txtTiempo.Text = "";
            TxtDistancia.Text = "";
            TxtVelocidad.Text = "";
        }
    }
}
