using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategorias(string nome)
        {
            try
            {
                //conecta no banco de dados
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //oq ele vai executar do sql
                string sql = "INSERT INTO tbcategorias (categorias) VALUES (@nome);";

                //abri a conexao com o banco de dados
                conexao.Open();

                //executa o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //troca o valor dos @ pelas informações que serão cadastradas 
                //essas informações vieram das funções
                comando.Parameters.AddWithValue("@nome", nome);

                //executando no banco de dados - o execute etc retorna a quantidade de linhas afetadas
                int linhasAfetadas = comando.ExecuteNonQuery();

                //encerrando a conexao
                conexao.Close();

                //se a quantidade de linhas que ele afetou for maior que 0, retorna true - se conseguiu cadastrar
                if (linhasAfetadas > 0)
                {
                    return true;
                }

                //se não conseguiu, retorna false (< 0 linhas)
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                //aparece quando da erro, a segunda aspas eh o titulo, o buttons cria um botão e o icon cria um icone
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }       
    }
}
