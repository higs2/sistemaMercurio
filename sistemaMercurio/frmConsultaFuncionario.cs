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
    public partial class frmConsultaFuncionario : Form
    {

        FuncionarioController funcinarioController = new FuncionarioController();

        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void frmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncinario.DataSource = funcinarioController.exibirFuncionarios();
            dgvFuncinario.Columns[0].Width = 50;
            dgvFuncinario.Columns[1].Width = 100;
            dgvFuncinario.Columns[2].Width = 200;
            dgvFuncinario.Columns[3].Width = 120;
            dgvFuncinario.Columns[4].Width = 120;
            dgvFuncinario.Columns[5].Width = 80;
            dgvFuncinario.Columns[6].Width = 50;

            dgvFuncinario.Columns[0].HeaderText = "ID";
            dgvFuncinario.Columns[1].HeaderText = "Matrícula";
            dgvFuncinario.Columns[2].HeaderText = "Nome";
            dgvFuncinario.Columns[3].HeaderText = "Departamento";
            dgvFuncinario.Columns[4].HeaderText = "Cargo";
            dgvFuncinario.Columns[5].HeaderText = "Salário";
            dgvFuncinario.Columns[6].HeaderText = "Status";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?","Excluir",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Funcionario func = new Funcionario();
                func.id_funcionario = Convert.ToInt32(dgvFuncinario.SelectedRows[0].Cells[0].Value);
                bool resultado = funcinarioController.deletarFuncinario(func);
                if (resultado)
                {
                    MessageBox.Show("Registro excluido com sucesso", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvFuncinario.DataSource = funcinarioController.exibirFuncionarios();
                    dgvFuncinario.Refresh();
                }
                else
                {
                    MessageBox.Show("Error ao excluir o registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       
    }
}
