using ProjetoAgenda.Controller;
using ProjetoAgenda.VariableGlobal;
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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void AtualizaDataGrid()
        {
            //atualizar a tabela

            ContatoController controleContato = new ContatoController();

            DataTable tabela = controleContato.GetContatos();

            dgvContatos.DataSource = tabela;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            //pegando os dados do formulario
            string nome = txtNome.Text;
            string categoria = txtCategoria.Text;

            //chamando a classe
            ContatoController criaContato = new ContatoController();

            //inserindo o usuario
            bool resultado = criaContato.AddContato(nome, categoria);

            if (resultado)
            {
                MessageBox.Show("Contato cadastrado com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possivel cadastrar o contato.");
            }

            AtualizaDataGrid();
        }
    }
}
