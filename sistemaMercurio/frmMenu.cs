using sistemaMercurio.Controllers;
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
    public partial class frmMenu : Form
    {
        public frmMenu(string nome)
        {
            InitializeComponent();
            usuarioLogado.Text = nome;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair","Saindo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                frmLogin login = new frmLogin();
                login.Show();
            }
         

        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {           
            Application.Exit();
           
        }

        private void geradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmGerador gerador = new frmGerador();
            gerador.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
        }

        private void calculadoraTesteeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadoraTeste calculadoraTeste = new frmCalculadoraTeste();
            calculadoraTeste.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.ShowDialog();
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario consultaFuncionario = new frmConsultaFuncionario();
            consultaFuncionario.ShowDialog();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarUsuario consultaUsuario = new frmConsultarUsuario();
            consultaUsuario.ShowDialog();
        }

        private void funcionárioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioFuncionario relatorioFuncionario = new frmRelatorioFuncionario();
            relatorioFuncionario.ShowDialog();
        }
    }
}
