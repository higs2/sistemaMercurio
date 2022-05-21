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
            verificarSenha();
            MessageBox.Show("Usuário " + txtNome.Text + "\nCadastrado com sucesso" +
                "\nInformações de Login" +
                "\nLogin: " + txtEmail.Text +
                "\nSenha:" + txtSenha.Text, "Cadastrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            verificarSenha();
        }

       
    }
}
