namespace física_EH
{
    public partial class Menú : System.Windows.Forms.Form
    {
        public Menú()
        {
            InitializeComponent();
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
            VolumenDeFiguras.ShowDialog();
        }
        //no se sabe todavía
        private void BtnCronómetro_Click(object sender, EventArgs e)
        {
            /*nombre de la pestaña = */
            Cronómetro cronos = new();
            cronos.ShowDialog();
        }
        // Leyes De Newton

        private void BtnNewton_Click_1(object sender, EventArgs e)
        {
            LeyesDeNewton newton = new();
            newton.ShowDialog();
        }

        private void BtnAcustica_Click(object sender, EventArgs e)
        {
            Acustica acustica = new();
            acustica.ShowDialog();
        }

        private void BtnCinematica_Click(object sender, EventArgs e)
        {
            Cinematica cinematica = new();
            cinematica.ShowDialog();
        }

        private void BtnAcustica_Click_1(object sender, EventArgs e)
        {
            Acustica acustica = new();
            acustica.ShowDialog();
        }
        //Óptica
        private void BtnOptica_Click(object sender, EventArgs e)
        {
            Óptica optica = new();
            optica.ShowDialog();
        }
        //Tensión
        private void BtnTensión_Click(object sender, EventArgs e)
        {
            Tensión tensión = new();
            tensión.ShowDialog();
        }

        private void BtnElectrónica_Click(object sender, EventArgs e)
        {
            Electrónica electrónica = new();
            electrónica.ShowDialog();
        }
    }
}