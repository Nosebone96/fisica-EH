using System.Drawing;
using System.Windows.Forms;
using static física_EH.Program;

namespace física_EH
{
    public partial class Menú : System.Windows.Forms.Form
    {
        public Menú()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        //porcentaje de error
        private void BtnPorError_Click_1(object sender, EventArgs e)
        {
            Error ventanaporerror = new();
            ventanaporerror.ShowDialog();
        }
        //Volumen de figuras
        private void BtnFiguras_Click_1(object sender, EventArgs e)
        {
            Volumen VolumenDeFiguras = new();
            VolumenDeFiguras.Show();
        }
        //no se sabe todavía
        private void BtnCronómetro_Click(object sender, EventArgs e)
        {
            /*nombre de la pestaña = */
            Cronómetro cronos = new();
            cronos.Show();
        }
        private void BtnAcustica_Click(object sender, EventArgs e)
        {
            Acustica acustica = new();
            acustica.Show();
        }
        //acústica
        private void BtnAcustica_Click_1(object sender, EventArgs e)
        {
            Acustica acustica = new();
            acustica.Show();
        }
        //Óptica
        private void BtnOptica_Click(object sender, EventArgs e)
        {
            Óptica optica = new();
            optica.Show();
        }
        //electrónica
        private void BtnElectrónica_Click(object sender, EventArgs e)
        {
            Electrónica electrónica = new();
            electrónica.Show();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void BtnMecánica_Click(object sender, EventArgs e)
        {
            Mecánica mecanica = new();
            mecanica.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }
    }
}