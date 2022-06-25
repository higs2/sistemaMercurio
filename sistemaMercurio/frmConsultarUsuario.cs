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

namespace sistemaMercurio.Controllers
{
    public partial class frmConsultarUsuario : Form
    {
        UsuarioController usuarioController = new UsuarioController();

        public frmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = usuarioController.exibirUsuarios();
            dgvUsuario.Columns[0].Width = 50;
            dgvUsuario.Columns[1].Width = 100;
            dgvUsuario.Columns[2].Width = 200;
            dgvUsuario.Columns[3].Width = 120;
            dgvUsuario.Columns[4].Width = 120;
            dgvUsuario.Columns[5].Width = 80;
            dgvUsuario.Columns[6].Width = 80;
            dgvUsuario.Columns[7].Width = 80;
            dgvUsuario.Columns[8].Width = 80;
            dgvUsuario.Columns[9].Width = 80;
            dgvUsuario.Columns[10].Width = 80;
            dgvUsuario.Columns[11].Width = 80;
            dgvUsuario.Columns[12].Width = 80;

            dgvUsuario.Columns[0].HeaderText = "ID";
            dgvUsuario.Columns[1].HeaderText = "Email";
            dgvUsuario.Columns[2].HeaderText = "Nome";
            dgvUsuario.Columns[3].HeaderText = "Função";
            dgvUsuario.Columns[4].HeaderText = "Data Nascimento";
            dgvUsuario.Columns[5].HeaderText = "CPF";
            dgvUsuario.Columns[6].HeaderText = "Celular";
            dgvUsuario.Columns[7].HeaderText = "CEP";
            dgvUsuario.Columns[8].HeaderText = "Endereço";
            dgvUsuario.Columns[9].HeaderText = "Número";
            dgvUsuario.Columns[10].HeaderText = "UF";
            dgvUsuario.Columns[11].HeaderText = "Bairro";
            dgvUsuario.Columns[12].HeaderText = "Cargo";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o usuário?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Usuario user = new Usuario();
                user.id_usuario = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells[0].Value);
                bool resultado = usuarioController.deletarFuncinario(user);
                if (resultado)
                {
                    MessageBox.Show("Usuário excluido com sucesso", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuario.DataSource = usuarioController.exibirUsuarios();
                    dgvUsuario.Refresh();
                }
                else
                {
                    MessageBox.Show("Error ao excluir o usuário", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
