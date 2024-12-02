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
            try
            {
                //conecta no banco de dados
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

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
                string sql = @"select nome, usuario, categorias from tbcategorias";

                //abri a conexao
                conexao.Open();

                //criei um adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //MySqlCommand comando = new MySqlCommand(sql, conexao);


                //comando.Parameters.AddWithValue("@usuario", $"{UserSession.usuario}@%");

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
    }
}
