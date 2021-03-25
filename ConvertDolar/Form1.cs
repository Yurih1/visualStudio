using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertDolar
{
    public partial class frnConvert : Form
    {
        public frnConvert()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConversao_Click(object sender, EventArgs e)
        {
            double cotacao, dolar; //valor do dolar no dia // valor do usuario
            double conversao;

            cotacao = Convert.ToDouble(txtDiaDolar.Text);
            dolar = Convert.ToDouble(txtQuantDolar.Text);

            conversao = cotacao * dolar;

            lblResultado3.Text = ("A conversão em Reias é R$ " + conversao);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtDiaDolar.Text = ""; // limpa a txtbox
            txtQuantDolar.Text = "";
            lblResultado3.Text = "";
            txtDiaDolar.Focus(); // colocar o foco do cursor na txtbox
        }
    }
}
