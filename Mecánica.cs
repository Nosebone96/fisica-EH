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
    public partial class Mecánica : Form
    {
        public Mecánica()
        {
            InitializeComponent();
        }


        private void BtnDinamica_Click(object sender, EventArgs e)
        {
            Dinámica dinamica = new();
            dinamica.Show();
            this.Hide();
        }

        private void BtnCinematica_Click(object sender, EventArgs e)
        {
            Cinematica cinematica = new();
            cinematica.Show();
            this.Hide();
        }
    }
}
