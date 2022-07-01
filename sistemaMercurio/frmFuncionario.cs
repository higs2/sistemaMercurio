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

        Funcionario funcionario = new Funcionario();
        public frmFuncionario()
        {
            InitializeComponent();
        }

        public frmFuncionario(Funcionario func)
        {
            InitializeComponent();
            funcionario = func;
            carregarEditar();
        }

        public void carregarEditar()
        {
            btnCadastrar.Visible = false;
            btnLimpar.Visible = false;
            btnSalvar.Visible = true;

            txtNome.Text = funcionario.nome;
            txtMatricula.Text = funcionario.matricula;
            txtDepartamento.Text = funcionario.departamento;
            txtCargo.Text = funcionario.cargo;
            txtSalario.Text = funcionario.salario.ToString();
            txtStatus.Text = funcionario.status;
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
                    txtMatricula.Text,
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
           
            this.Close();

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            funcionario.nome = txtNome.Text;
            funcionario.matricula = txtMatricula.Text;
            funcionario.departamento = txtDepartamento.Text;
            funcionario.cargo = txtCargo.Text;
            funcionario.salario = Convert.ToDouble(txtSalario.Text);
            funcionario.status = txtSalario.Text;

            FuncionarioController funcionarioController = new FuncionarioController();
            bool resultado = funcionarioController.editarFuncionario(funcionario);

            if (resultado)
            {
                MessageBox.Show("Funcionado atualizado com sucesso", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao atualizar o funcionário", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
