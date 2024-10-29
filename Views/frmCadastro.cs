using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void habilitarBotaoCadastrar()
        {
            if (txtNome.Text != "" && txtUsuario.Text != "" && txtSenha.Text.Length >= 8 && txtRepitaSenha.Text == txtSenha.Text)
            {
                //se o texto do usuario for diferente de vazio e a senha for maior ou igual 8, o botao de login habilita
                btnCadastrar.Enabled = true;
            }

            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtRepitaSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = ConexaoDB.CriarConexao();
            //abrindo conexão
            conexao.Open();

            //criando o comando sql para inserir o usuario
            string sql = $"INSERT INTO tb_usuarios (nome, usuario, senha) VALUES (@nome, @usuario, @senha)";

            //criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);

            //executando a instrução sql no banco de dados 
            comando.ExecuteNonQuery();

            //fechando a conexão com o banco
            conexao.Clone();

            MessageBox.Show("Cadastro efetuado com sucesso! \n Você já pode fazer o login");

            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

