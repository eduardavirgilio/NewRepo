﻿using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using ProjetoAgenda.Controller;
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
            //pegando os dados do formulario
            string nome = txtNome.Text;
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            //chamando a classe
            UsuarioController controleUsuario = new UsuarioController();

            //inserindo o usuario
            bool resultado = controleUsuario.AddUsuario(nome, usuario, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possivel cadastrar o usuário.");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

