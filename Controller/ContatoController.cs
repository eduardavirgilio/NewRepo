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
        public DataTable GetContatos()
        {
            //criando uma conexao vazia
            MySqlConnection conexao = null;
            try
            {
                //criando uma conexao com a conexao db que ja estava criada
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //montando o select que retorna todas as categorias
                string sql = @"select cod_categoria, usuario, categorias from tbcategorias where usuario = User();";

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
                MessageBox.Show($"ERRO AO RECUPERAR CATEGORIAS: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }
        }
}
