using MySql.Data.MySqlClient;
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
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda
{
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();

            //bool resultado = controleUsuario.ValidarLogin("alex", "12345678");
            bool resultado = controleUsuario.ValidarLogin("godo", "AlexLindo");
            MessageBox.Show(resultado.ToString());


        }

        private void btnTeste2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao("lucas1", "12345678");
                conexao.Open();
                MessageBox.Show("Conexão deu certo!");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao conectar! {erro.Message}");
            }
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            UserSession.usuario = texto.Text;
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.usuario);
        }

        private void nome_Click(object sender, EventArgs e)
        {
            UserSession.nome = textonome.Text;
        }

        private void botaosenha_Click(object sender, EventArgs e)
        {
            UserSession.senha = textBox1.Text;
        }

        private void clica_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.nome);
        }

        private void botaoclica_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.senha);
        }
    }
}
