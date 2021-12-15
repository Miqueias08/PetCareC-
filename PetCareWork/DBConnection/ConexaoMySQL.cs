using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace PetCareWork.DBConnection
{
    class ConexaoMySQL
    {
        private string conexao = "Server=localhost; Database=dbLojaTarde; Uid=root;Pwd=";

        //Abre o Banco de Dados e retorna um objeto SqlConnection:
        private MySqlConnection AbrirBanco()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            return con;
        }

        //Método para fechar o Banco de dados:
        public void FecharBanco(MySqlConnection con)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //Método para rodar um comando SQL (INSERT, UPDATE)
        public void ExecutarComando(string query)
        {
            MySqlConnection con = new MySqlConnection();

            try
            {
                con = AbrirBanco();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = query.ToString();
                comando.CommandType = CommandType.Text;
                comando.Connection = con;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharBanco(con);
            }
        }

        //Método para rodar uma consulta SQL (SELECT - retorna um DataTableCollection):
        public DataTableCollection Consulta(string query)
        {
            MySqlConnection con = new MySqlConnection();

            try
            {
                con = AbrirBanco();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = query.ToString();
                comando.CommandType = CommandType.Text;
                comando.Connection = con;
                comando.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet dsDados = new DataSet();
                adapter.SelectCommand = comando;
                adapter.Fill(dsDados, "Dados"); //"Dados" é o nome do indice p da tabela de resultados
                return dsDados.Tables;          //Pode ser utilizado o índice [0] ao invés de ["Dados"] 
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharBanco(con);
            }
        }
    }
}
