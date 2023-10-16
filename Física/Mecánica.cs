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

        private void BtnMRU_Click(object sender, EventArgs e)
        {
            EcuaciónH ventanaEcuaciónH = new();
            ventanaEcuaciónH.Show();
            this.Close();
        }

        private void BtnMRUV_Click(object sender, EventArgs e)
        {
            MRUV MRUVF = new();
            MRUVF.Show();
            this.Close();
        }

        private void BtnMVCl_Click(object sender, EventArgs e)
        {
            MVCL caidaLibre = new();
            caidaLibre.Show();
            this.Close();
        }

        private void BtnNewton_Click(object sender, EventArgs e)
        {
            LeyesDeNewton newton = new();
            newton.Show();
            this.Close();
        }

        private void BtnLeyDeHooke_Click(object sender, EventArgs e)
        {
            LeyDeHooke Hoooke = new();
            Hoooke.ShowDialog();
        }
    }
}
