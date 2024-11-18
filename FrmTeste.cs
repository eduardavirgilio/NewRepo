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
    }
}
