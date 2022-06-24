using MySql.Data.MySqlClient;
using sistemaMercurio.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            

        }

        public bool salvarFuncionario(Funcionario func)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO funcionario (nome,matricula,departamento,cargo,salario,status) " +
                                                                    "VALUES (@nome,@matricula,@departamento,@cargo,@salario,@status)", conexao);

                cmd.Parameters.AddWithValue("@nome", func.nome);
                cmd.Parameters.AddWithValue("@matricula", func.matricula);
                cmd.Parameters.AddWithValue("@departamento",func.departamento);
                cmd.Parameters.AddWithValue("@cargo", func.cargo);
                cmd.Parameters.AddWithValue("@salario", func.salario);
                cmd.Parameters.AddWithValue("@status", func.status);
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

        public DataTable exibirFuncionarios()
        {
            DataTable dt = new DataTable();
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT id_funcionario,matricula,nome,departamento,cargo,salario,status FROM funcionario", conexao);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (MySqlException)
            {

                return dt;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deletarFuncinario(Funcionario func)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM funcionario WHERE id_funcionario = @id_funcionario", conexao);
                cmd.Parameters.AddWithValue("@id_funcionario", func.id_funcionario);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
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
