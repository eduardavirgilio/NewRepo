﻿using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
            //string contendo as infomações para a conexão
            string stringConexao = "Server=localhost;Database=dbAgenda;User ID=root;Password=root;";
            
            //criando a conexão
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            //abrindo conexão
            conexao.Open();

            //criando o comando sql para inserir o usuario
            string sql = $"INSERT INTO tb_usuarios (nome, usuario, senha) VALUES ('{txtNome.Text}', '{txtUsuario.Text}', '{txtSenha.Text}')";

            //criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            //executando a instrução sql no banco de dados 
            comando.ExecuteNonQuery();

            //fechando a conexão com o banco
            conexao.Clone();

            MessageBox.Show("Cadastro efetuado com sucesso! \n Você já pode fazer o login");

            this.Close();
        }
    }

}

