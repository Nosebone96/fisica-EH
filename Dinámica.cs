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
    public partial class Dinámica : Form
    {
        public Dinámica()
        {
            InitializeComponent();
        }

        private void BtnNewton_Click_1(object sender, EventArgs e)
        {
            LeyesDeNewton newton = new();
            newton.Show();
            this.Close();
        }

        private void BtnTensión_Click(object sender, EventArgs e)
        {
            Tensión tensión = new();
            tensión.Show();
            this.Close();
        }
    }
}
