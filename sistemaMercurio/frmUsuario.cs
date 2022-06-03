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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Deseja cancelar o cadastro? ","Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();

            }
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();            
            txtCPF.Clear();           
            txtCel.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();        

        }


        private void verificarSenha()
        {
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                lblErro.Text = "As senhas não são iguais!";
                txtConfirmarSenha.Clear();
                txtSenha.Clear();
            }
            else
            {
                lblErro.Text = "";
            }

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario
            (
                    txtNome.Text,
                    txtEmail.Text,
                    txtSenha.Text,
                    txtFuncao.Text,
                    txtCPF.Text,
                    txtNascimento.Text,
                    txtCel.Text,
                    txtCep.Text,
                    txtEndereco.Text,
                    Convert.ToInt32(txtNumero.Text),
                    txtUf.Text,
                    txtBairro.Text,
                    txtCargo.Text
            );
            UsuarioController usuarioController = new UsuarioController();
            bool verifica = usuarioController.salvarUsuario(user);

            if (verifica)
            {
                MessageBox.Show("Usuário cadastrado com sucesso","Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                if (MessageBox.Show("Deseja Continuar cadastrando","Cadastro",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            verificarSenha();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }
    }
}
