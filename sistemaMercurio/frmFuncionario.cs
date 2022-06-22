using sistemaMercurio.Controllers;
using sistemaMercurio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaMercurio
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtMatricula.Clear();
            txtDepartamento.Text = "";
            txtCargo.Clear();
            txtSalario.Clear();
            txtStatus.Text = "";

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario user = new Funcionario
            (
                    txtNome.Text,
                    Convert.ToInt32(txtMatricula.Text),
                    txtDepartamento.Text,                    
                    txtCargo.Text,
                    Convert.ToDouble(txtSalario.Text),
                    txtStatus.Text
            );
            FuncionarioController usuarioController = new FuncionarioController();
            bool verifica = usuarioController.salvarFuncionario(user);

            if (verifica)
            {
                MessageBox.Show("Usuário cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Deseja Continuar cadastrando", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limparCampos();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o usuário", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cadastro? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();

            }
        }
    }
}
