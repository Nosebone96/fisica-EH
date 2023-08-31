using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace física_EH
{
    public partial class MRUV : Form
    {
        public MRUV()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        public void BtnCalcular_Click(object sender, EventArgs e)
        {

            _ = Double.TryParse(txtAceleración.Text, out double aceleracion);
            _ = Double.TryParse(txtDistancia.Text, out double distancia);
            _ = Double.TryParse(txtTiempo.Text, out double Tiempo);
            _ = Double.TryParse(txtVelocidadInicial.Text, out double velocidadInicial);
            _ = Double.TryParse(txtVelocidadFinal.Text, out double velocidadFinal);

            int i = 0;
            while (i < 2)
            {
                //
                //para velocidad inicial
                //
                if (txtVelocidadInicial.Text == "")
                {
                    if (txtDistancia.Text != "" && txtTiempo.Text != "")
                    {
                        velocidadInicial = distancia / (Tiempo / 2);
                        goto siguiente1;
                    }
                    if (txtVelocidadInicial.Text == "" && txtVelocidadFinal.Text != "" && txtAceleración.Text != "" && txtTiempo.Text != "")
                    {
                        velocidadInicial = velocidadFinal - aceleracion * Tiempo;
                        goto siguiente1;
                    }
                    if (txtVelocidadInicial.Text == "" && txtVelocidadFinal.Text != "" && txtAceleración.Text != "" && txtDistancia.Text != "")
                    {
                        velocidadInicial = Math.Sqrt((velocidadFinal - 2 * aceleracion * distancia));
                        goto siguiente1;
                    }
                    /*if (txtDistancia.Text != "" && txtTiempo.Text != "")
                    {
                        velocidadInicial = distancia / Tiempo;
                    }*/
                }
siguiente1:
//
//para distancia
//
                if (txtDistancia.Text == "0" || txtDistancia.Text == "")
                {

                    if (txtVelocidadFinal.Text != "" && txtTiempo.Text != "" && txtAceleración.Text != "")
                    {
                        distancia = velocidadInicial * Tiempo + (aceleracion * Math.Pow(Tiempo, 2)) / 2;
                        goto siguiente2;
                    }
                    if (txtDistancia.Text == "" && txtVelocidadInicial.Text != "" && txtTiempo.Text != "" && txtAceleración.Text != "")
                    {
                        distancia = velocidadInicial * Tiempo + 0.5 * aceleracion * Math.Pow(Tiempo, 2);
                        goto siguiente2;
                    }
                    if (txtDistancia.Text == "" && txtTiempo.Text != "" && txtAceleración.Text != "" && txtVelocidadFinal.Text != "")
                    {
                        distancia = velocidadFinal * Tiempo - 0.5 * aceleracion * Math.Pow(Tiempo, 2);
                        goto siguiente2;
                    }
                    if (txtVelocidadInicial.Text != "" && txtVelocidadFinal.Text != "" && txtTiempo.Text != "")
                    {
                        distancia = ((velocidadInicial + velocidadFinal) / 2) * Tiempo;
                        goto siguiente2;
                    }
                }
siguiente2:
//
//para Tiempo
//
                if (txtTiempo.Text == "0" || txtTiempo.Text == "")
                {
                    /*if (txtVelocidadFinal.Text != "" && txtVelocidadInicial.Text != "" && txtAceleración.Text != "")
                    {
                        Tiempo = (velocidadFinal - velocidadInicial) / aceleracion;
                        goto siguiente3;
                    }*/
                    if (txtDistancia.Text != "" && txtVelocidadInicial.Text != "" && txtVelocidadFinal.Text != "")
                    {
                        Tiempo = distancia / ((velocidadInicial + velocidadFinal) / 2);
                        goto siguiente3;
                    }
                }
siguiente3:
//
//Para aceleración
//
                if (txtAceleración.Text == "0" || txtAceleración.Text == "")
                {
                    if (txtVelocidadInicial.Text != "" && txtVelocidadFinal.Text != "" && txtTiempo.Text != "")
                    {
                        aceleracion = (velocidadFinal - velocidadInicial) / Tiempo;
                        goto siguiente4;
                    }
                    if (txtDistancia.Text != "" && txtVelocidadInicial.Text != "" && txtTiempo.Text != "" && txtVelocidadFinal.Text == "")
                    {
                        aceleracion = (distancia - (velocidadInicial * Tiempo)) / (0.5 * Math.Pow(Tiempo, 2));
                        goto siguiente4;
                    }
                    if (txtDistancia.Text != "" && txtTiempo.Text != "" && txtVelocidadFinal.Text != "" && txtVelocidadInicial.Text != "")
                    {
                        aceleracion = (distancia + (velocidadFinal * Tiempo)) / (0.5 * Math.Pow(Tiempo, 2));
                        goto siguiente4;
                    }
                }
siguiente4:
//
//para velocidad final
//
                if (txtVelocidadFinal.Text == "")
                {
                    if (txtVelocidadInicial.Text != "" && txtAceleración.Text != "" && txtTiempo.Text != "")
                    {
                        velocidadFinal = velocidadInicial + aceleracion * Tiempo;
                        goto siguiente5;
                    }
                    if (txtVelocidadInicial.Text != "" && txtAceleración.Text != "" && txtDistancia.Text != "")
                    {
                        velocidadFinal = Math.Sqrt(Math.Pow(velocidadInicial, 2) + 2 * aceleracion * distancia);
                        goto siguiente5;
                    }
                    if (txtDistancia.Text != "" && txtTiempo.Text != "" && txtVelocidadInicial.Text != "")
                    {
                        velocidadFinal = 2 * (distancia / Tiempo) - velocidadInicial;
                        goto siguiente5;
                    }
                }
siguiente5:
                txtAceleración.Text = "" + aceleracion;
                txtDistancia.Text = "" + distancia;
                txtTiempo.Text = "" + Tiempo;
                txtVelocidadFinal.Text = "" + velocidadFinal;
                txtVelocidadInicial.Text = "" + velocidadInicial;
                // condición
                i++;
            }
            lblTiempo.Text = "" + Tiempo + "s";
            lblAceleración.Text = "" + aceleracion + "m/s²";
            lblDistancia.Text = "" + distancia + "m";
            lblVelocidadFinal.Text = "" + velocidadFinal + "m/s";
            lblVelocidadInicial.Text = "" + velocidadInicial + "m/s";

        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtAceleración.Text = "";
            txtDistancia.Text = "";
            txtTiempo.Text = "";
            txtVelocidadFinal.Text = "";
            txtVelocidadInicial.Text = "";
            lblTiempo.Text = "";
            lblAceleración.Text = "";
            lblDistancia.Text = "";
            lblVelocidadFinal.Text = "";
            lblVelocidadInicial.Text = "";
        }

        private void MRUV_Load(object sender, EventArgs e)
        {

        }
    }
}