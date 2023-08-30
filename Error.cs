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
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double va = double.Parse(txtvalA.Text);
                double ve = double.Parse(txtvalEx.Text);
                double porerror = ((va - ve) / va) * 100;
                if (porerror < 0)
                {
                    porerror *= -1;
                }
                lblporerror1.Text = "" + porerror + "%";
            }
            catch
            {
                lblporerror1.Text = "los valores digitados son incorrectos :(";
            }
        }
        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            lblporerror1.Text = "";
            txtvalA.Text = "";
            txtvalEx.Text = "";
        }
    }
}
