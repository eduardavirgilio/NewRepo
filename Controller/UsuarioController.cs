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
    internal class UsuarioController
    {
        // add usuario eh um metodo
        public bool AddUsuario(string nome, string usuario, string senha)
        {
            try
            {
                //conecta no banco de dados
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //oq ele vai executar do sql
                string sql = "INSERT INTO tbusuarios (nome, usuario, senha) VALUES (@nome, @usuario, @senha);";

                //abri a conexao com o banco de dados
                conexao.Open();

                //executa o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //troca o valor dos @ pelas informações que serão cadastradas 
                //essas informações vieram das funções
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

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

        public bool ValidarLogin(string usuario, string senha)
        {
            try
            {
                //conecta no banco de dados
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = @"select * from tbusuarios 
                         where usuario = @usuario
                         and binary senha = @senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    return true;
                }

                else
                {
                    conexao.Close();
                    return false;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao verificar o usuario.");
                return false;
            }

        }

        public DataTable GetUsuarios()
        {
            //criando uma conexao vazia
            MySqlConnection conexao = null;
            try
            {
                //criando uma conexao com a conexao db que ja estava criada
                conexao = ConexaoDB.CriarConexao();

                //montando o select que retorna todas as categorias
                string sql = @"select usuario, nome from tbusuarios;";

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
                MessageBox.Show($"ERRO AO RECUPERAR USUARIOS: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }
        }

            public bool ExcluirUsuario(string usuario)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                //montando o select que retorna todas as categorias
                string sql = @"delete from tbusuarios where usuario = (@usuario);";

                //abri a conexao com o banco de dados
                conexao.Open();

                //executa o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //troca o valor dos @ pelas informações que serão cadastradas 
                //essas informações vieram das funções
                comando.Parameters.AddWithValue("@usuario", usuario);

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
                MessageBox.Show($"Erro ao apagar o usuario: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                //encerrando a conexao
                conexao.Close();
            }
        }

        public bool AlterarSenha(string senha, string usuario)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                //montando o select que retorna todas as categorias
                string sql = @"update tbusuarios set senha = (@senha) where usuario = (@usuario);";

                //abri a conexao com o banco de dados
                conexao.Open();

                //executa o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //troca o valor dos @ pelas informações que serão cadastradas 
                //essas informações vieram das funções
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@usuario", usuario);

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
                MessageBox.Show($"Erro ao alterar senha : {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
