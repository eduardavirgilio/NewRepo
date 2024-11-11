using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Data
{
    static public class ConexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            //string contendo as infomações para a conexão
            string stringConexao = "Server=localhost;Database=dbagenda;User ID=root;Password=root;";

            //criando a conexão
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;

        }

     
        
    }
}
