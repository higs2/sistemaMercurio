using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaMercurio.Models
{
    internal class Funcionario
    {
        public int id_funcionario { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }
        public string status { get; set; }


        public Funcionario()
        {

        }

        public Funcionario
            (
            string _nome,
            string _matricula,
            string _departamento,
            string _cargo,
            double _salario,
            string _status
            )
        {
            nome = _nome;
            matricula = _matricula;
            departamento = _departamento;            
            cargo = _cargo;
            salario = _salario;
            status = _status;
            

        }
    }
        
}
