using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class fmrNumeroQuadrado : Form
    {
        public fmrNumeroQuadrado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int A, R;

            A = Convert.ToInt32(txtNumero1.Text);
            R = A * A;
            lblResultado2.Text = R.ToString();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            lblResultado2.Text = "";

        }
    }
}
