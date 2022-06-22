using MySql.Data.MySqlClient;
using sistemaMercurio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaMercurio.Controllers
{
    internal class FuncionarioController
    {
        MySqlConnection conexao = new MySqlConnection();

        public FuncionarioController()
        {
            conexao = Conexao.Conectar();
            conexao.Open();

        }

        public bool salvarFuncionario(Funcionario user)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO funcionario (nome,matricula,departamento,cargo,salario,status) " +
                                                                    "VALUES (@nome,@matricula,@departamento,@cargo,@salario,@status)", conexao);

                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@matricula", user.matricula);
                cmd.Parameters.AddWithValue("@departamento",user.departamento);
                cmd.Parameters.AddWithValue("@cargo", user.cargo);
                cmd.Parameters.AddWithValue("@salario", user.salario);
                cmd.Parameters.AddWithValue("@status", user.status);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException)
            {
                return false;


            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
