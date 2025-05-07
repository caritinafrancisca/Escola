using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Drawing.Text;
namespace Escola.Dados
{
    public class DBconnections
    {
      
        
            //configura o uso da string de conexão
            private static string connectionString = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            public static MySqlConnection GetConnection() 
            {
            return new MySqlConnection(connectionString);
            }
            //criar
            public void Cadastrar(int idalunos,string nome, string email, string telefone)
        {
                try
            {
                MySqlConnection mySqlConnection = DBconnections.GetConnection();
                using MySqlConnection conn = mySqlConnection;
                conn.Open();
                string query = "INSERT INTO alunos(idalunos, nome, email, telefone)" +
                    "VALUES (@idalunos, @nome, @email, @telefone)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idalunos", idalunos);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);

                cmd.ExecuteNonQuery();
                conn.Close();

   
            }
            catch (Exception ex)
            {
                string Erro = ex.Message.ToString().Trim();
            }

        }
    }
}
