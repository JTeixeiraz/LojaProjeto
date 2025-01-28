using System;
using System.Collections.Generic;
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
    }
}
