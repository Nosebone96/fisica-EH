using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace física_EH
{
    public partial class MVCL : Form
    {
        public MVCL()
        {
            InitializeComponent();
        }

        private void MVCL_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcularMVCL_Click(object sender, EventArgs e)
        {
            _ = Double.TryParse(txtGravedad.Text, out double aceleracion);
            _ = Double.TryParse(txtAltura.Text, out double distancia);
            _ = Double.TryParse(txtTiempo.Text, out double Tiempo);
            _ = Double.TryParse(txtVelocidadInicial.Text, out double velocidadInicial);
            _ = Double.TryParse(txtVelocidadFinal.Text, out double velocidadFinal);

            int i = 0;
            while (i < 2)
            {
                if (txtAltura.Text == "")
                {

                }
                if (txtTiempo.Text == "")
                {

                }
                if (txtVelocidadFinal.Text == "")
                {

                }
                if (txtVelocidadInicial.Text == "")
                {

                }
                if(txtGravedad.Text == "")
                {

                }
                i++;
            }
        }
    }
}
