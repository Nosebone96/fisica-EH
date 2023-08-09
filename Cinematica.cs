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
    public partial class Cinematica : Form
    {
        public Cinematica()
        {
            InitializeComponent();
        }

        private void BtnEcuaciónHoraria_Click(object sender, EventArgs e)
        {
            EcuaciónH ventanaEcuaciónH = new();
            ventanaEcuaciónH.ShowDialog();
        }

        private void BtnMRUV_Click(object sender, EventArgs e)
        {
            MRUV MRUVF = new();
            MRUVF.ShowDialog();
        }

        private void BtnMVCL_Click(object sender, EventArgs e)
        {
            MVCL caidaLibre = new();
            caidaLibre.ShowDialog();
        }
    }
}
