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
    public partial class frmRelatorioFuncionario : Form
    {
        public frmRelatorioFuncionario()
        {
            InitializeComponent();
            FuncionarioController funcionarioController = new FuncionarioController();

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("Funcionario", funcionarioController.exibirFuncionarios())
                );
            this.reportViewer1.RefreshReport();
        }

        public frmRelatorioFuncionario(DataView dataView)
        {
            InitializeComponent();
          

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("Funcionario",dataView)
                );
            this.reportViewer1.RefreshReport();
        }


        private void frmRelatorioFuncionario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
