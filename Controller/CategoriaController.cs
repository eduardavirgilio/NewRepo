using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategorias(string nome)
        {
            //conecta no banco de dados (criando fora e em branco pra conexao do finally funcionar)
            MySqlConnection conexao = null;
            
            try
            {
               conexao = new ConexaoDB.CriarConexao();

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
                //caso de erro
            }
            catch (Exception erro)
            {
                //aparece quando da erro, a segunda aspas eh o titulo, o buttons cria um botão e o icon cria um icone
                MessageBox.Show($"Erro ao inserir categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                //encerrando a conexao
                conexao.Close( );
            }
        }

        public DataTable GetCategorias()
        {
            //criando uma conexao vazia
            MySqlConnection conexao = null ;
            try
            {
                //criando uma conexao com a conexao db que ja estava criada
                 conexao = ConexaoDB.CriarConexao();

                //montando o select que retorna todas as categorias
                string sql = @"select cod_categoria AS 'Código', categorias AS 'Categoria' from tbcategorias;";

                //abri a conexao
                conexao.Open();

                //criei um adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //tabela em branco
                DataTable tabela = new DataTable();

                //pedindo para o adaptador preencher a tabela
                adaptador.Fill(tabela);

                //retorno a tabela preenchida
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO RECUPERAR CATEGORIAS: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close( );
            }

        }
    }
}
