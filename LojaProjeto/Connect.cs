using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace LojaProjeto
{
    internal class Connect
    {
        MySqlConnection conn;

        //conectar ao banco de dados
        public void ConectarBD()
        {
            try
            {
                conn = new MySqlConnection("Persist Security info = false; server = localhost;  database = DBStore; user = root; password = pswd;");
                conn.Open();
                MessageBox.Show("Conecção feita");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        //Função para executar comandos no banco de dados
        int resultado;
        public int ExecutarComandos(string sql)
        {
            try
            {
                //faz a conecção com o banco de dados
                ConectarBD();
                //prepara para a execução do comando
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //executa o comando
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                resultado = 0;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return resultado;
        }

        //funcao para exibir uma tabela de dados

        public DataTable ExecutarTabela(string sql)
        {
            try
            {
                //faz a conecção com o banco de dados
                ConectarBD();
                //prepara para a execução do comando
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //executa o comando
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
