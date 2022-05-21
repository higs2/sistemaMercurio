using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistemaMercurio
{
    internal class Conexao
    {
        private static MySqlConnection conexao;
        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=dbmercurio");
                conexao.Open();
                MessageBox.Show("Banco conectado!","Conectado",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch ( MySqlException erro)
            {
                MessageBox.Show("Error na conexão: " + erro.Message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);                
               
            }
            
           
        }
    }
}
