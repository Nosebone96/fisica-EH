using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace física_EH
{
    public partial class Electrónica : Form
    {
        public Electrónica()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void BtnResistencia_Click(object sender, EventArgs e)
        {
            Resistencia resistencia = new();
            resistencia.ShowDialog();
        }

        private void BtnLeyDeOhm_Click(object sender, EventArgs e)
        {
            Ley_De_Ohm leydeohm = new();
            leydeohm.ShowDialog();
        }

        private void BtnLeyesDeKirchhcoff_Click(object sender, EventArgs e)
        {

        }
    }
}
