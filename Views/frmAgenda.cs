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

            CategoriaController controleCategoria = new CategoriaController();

            DataTable tabela = controleContato.GetContatos();

            dgvContatos.DataSource = tabela;

            tabela = controleCategoria.GetCategorias();
            cmbCategoria.DataSource = tabela;
            cmbCategoria.DisplayMember = "categorias";
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
            string categoria = cmbCategoria.Text;
            string usuario = UserSession.usuario;
            string senha = UserSession.senha;

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

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //pegando os dados do formulario
            string nome = txtNome.Text;
            string categoria = cmbCategoria.Text;
            int cod_contato = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);

            //chamando a classe
            ContatoController alterarNome = new ContatoController();

            //inserindo o usuario
            bool resultado = alterarNome.AlterarNome(nome, categoria, cod_contato);

            if (resultado)
            {
                MessageBox.Show("Nome e/ou categoria alterado com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possivel alterar o nome e/ou categoria.");
            }

            AtualizaDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //string cod_categoria = txtNome.Text;

            //para excluir a linha
            int cod_contato = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);

            //chamando a classe
            ContatoController excluiContato = new ContatoController();

            //inserindo o usuario
            bool resultado = excluiContato.ExcluirContato(cod_contato);

            if (resultado)
            {
                MessageBox.Show("Contato excluido com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possivel excluir o contato.");
            }

            //atualizar a tabela

            AtualizaDataGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
