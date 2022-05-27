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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginController login = new LoginController();
            Usuario user = new Usuario();
            user.email = txtUsuario.Text;
            user.senha = txtSenha.Text;

            DataTable result = login.fazerLogin(user);

            if (result.Rows.Count > 0)
            {
                MessageBox.Show("LOGADO COM SUCESSO","LOGADO",MessageBoxButtons.OK,MessageBoxIcon.Information);                   
                frmMenu menu = new frmMenu( result.Rows[0]["nome"].ToString());
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USUARIO OU SENHA INCORRETO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                LoginController login = new LoginController();
                Usuario user = new Usuario();
                user.email = txtUsuario.Text;
                user.senha = txtSenha.Text;

                DataTable result = login.fazerLogin(user);

                if (result.Rows.Count > 0)
                {
                    MessageBox.Show("LOGADO COM SUCESSO", "LOGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenu menu = new frmMenu(result.Rows[0]["nome"].ToString());
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("USUARIO OU SENHA INCORRETO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

       
    }
}
