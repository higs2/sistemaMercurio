using MySql.Data.MySqlClient;
using sistemaMercurio.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaMercurio.Controllers
{
    internal class UsuarioController
    {
        MySqlConnection conexao = new MySqlConnection();

        public UsuarioController()
        {
            conexao = Conexao.Conectar();            

        }

        public bool salvarUsuario(Usuario user)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO usuario (nome,email,senha,funcao,data_nascimento,cpf,celular,cep,endereco,numero,uf,bairro,cargo) " +
                                                    "VALUES (@nome,@email,@senha,@funcao,@data_nascimento,@cpf,@celular,@cep,@endereco,@numero,@uf,@bairro,@cargo)",conexao);

                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@senha", user.senha);
                cmd.Parameters.AddWithValue("@funcao", user.funcao);
                cmd.Parameters.AddWithValue("@data_nascimento", user.data_nascimento);
                cmd.Parameters.AddWithValue("@cpf", user.cpf);
                cmd.Parameters.AddWithValue("@celular", user.celular);
                cmd.Parameters.AddWithValue("@cep", user.cep);
                cmd.Parameters.AddWithValue("@endereco", user.endereco);
                cmd.Parameters.AddWithValue("@numero", user.numero);
                cmd.Parameters.AddWithValue("@uf", user.uf);
                cmd.Parameters.AddWithValue("@bairro", user.bairro);
                cmd.Parameters.AddWithValue("@cargo", user.cargo);
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

        public DataTable exibirUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT id_usuario,email,funcao,data_nascimento,cpf,celular,cep,logradouro,numero,numero,uf,bairro,cargo FROM usuario", conexao);
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

        public bool deletarFuncinario(Usuario user)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM usuario WHERE id_usuario = @id_usuario", conexao);
                cmd.Parameters.AddWithValue("@id_usuario", user.id_usuario);
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
