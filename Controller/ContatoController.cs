using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public bool AddContato(string nome, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                //conecta no banco de dados
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //oq ele vai executar do sql
                string sql = $@"INSERT INTO tbcontatos (nome, categoria) VALUES (@nome, @categoria);";


                //abri a conexao com o banco de dados
                conexao.Open();

                //executa o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //troca o valor dos @ pelas informações que serão cadastradas 
                //essas informações vieram das funções
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@categoria", categoria);

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
                MessageBox.Show($"Erro ao cadastrar o contato: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

        }

        public DataTable GetContatos()
        {
            //criando uma conexao vazia
            MySqlConnection conexao = null;
            try
            {
                //criando uma conexao com a conexao db que ja estava criada
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //montando o select que retorna todas as categorias
                string sql = @"select cod_contato, nome, categoria, usuario from tbcontatos where usuario = User();";

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
                MessageBox.Show($"ERRO AO RECUPERAR CONTATOS: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }
        }

        public bool AlterarNome(string nome, string categoria, int cod_categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //montando o select que retorna todas as categorias
                string sql = @"UPDATE dbagenda.tbcontatos SET nome = (@nome), categoria = (@categoria) WHERE cod_contato = (@codigo);";

                //abri a conexao com o banco de dados
                conexao.Open();

                //executa o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //troca o valor dos @ pelas informações que serão cadastradas 
                //essas informações vieram das funções
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@codigo", cod_categoria);
                comando.Parameters.AddWithValue("@categoria", categoria);

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
                MessageBox.Show($"Erro ao alterar categoria : {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                //encerrando a conexao
                conexao.Close();
            }
        }

        public bool ExcluirContato(int cod_contato)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //montando o select que retorna todas as categorias
                string sql = @"delete from tbcontatos where cod_contato = (@codigo_categoria);";

                //abri a conexao com o banco de dados
                conexao.Open();

                //executa o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //troca o valor dos @ pelas informações que serão cadastradas 
                //essas informações vieram das funções
                comando.Parameters.AddWithValue("@codigo_categoria", cod_contato);

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
                MessageBox.Show($"Erro ao apagar categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                //encerrando a conexao
                conexao.Close();
            }
        }
    }
}
