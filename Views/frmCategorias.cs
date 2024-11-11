using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //pegando os dados do formulario
            string nome = txtNome.Text;

            //chamando a classe
            CategoriaController criaCategoria = new CategoriaController();

            //inserindo o usuario
            bool resultado = criaCategoria.AddCategorias(nome);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possivel cadastrar o usuário.");
            }
        }
    }
}
