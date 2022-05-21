using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaMercurio
{
    public partial class frmCalculadoraTeste : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public frmCalculadoraTeste()
        {
            InitializeComponent();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            

            switch (operacao)
            {
                case "+":
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                    break;
                case "-":
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "*":
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                    break;
                case "/":
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                    break;
                default:
                    txtResultado.Text = "Error! operação inválida";
                    break;

            }
                
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "+";
                lblOpercao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para fazer a SOMA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "-";
                lblOpercao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para fazer a SUBTRAÇÃO!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "*";
                lblOpercao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para fazer a MULTIPLICAÇÃO!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "/";
                lblOpercao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para fazer a DIVISÃO!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
            if (txtResultado.Text == ".")
            {
                btnPonto.Enabled = false;
            }
        }

        private void btnNumCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnNumC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOpercao.Text = "";
        }

        
    }
}
