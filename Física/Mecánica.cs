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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }


        private void BtnDinamica_Click(object sender, EventArgs e)
        {
            Dinámica dinamica = new();
            dinamica.Show();
            this.Close();
        }

        private void BtnCinematica_Click(object sender, EventArgs e)
        {
            Cinematica cinematica = new();
            cinematica.Show();
            this.Close();
        }
    }
}
