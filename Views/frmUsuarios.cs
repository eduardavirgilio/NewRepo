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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void AtualizaDataGrid()
        {
            //atualizar a tabela

            UsuarioController controleUsuario = new UsuarioController();

            DataTable tabela = controleUsuario.GetUsuarios();

            dgvUsuario.DataSource = tabela;
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //para excluir a linha
            string usuarios = Convert.ToString(dgvUsuario.SelectedRows[0].Cells[0].Value);

            //chamando a classe
            UsuarioController excluiUsuario = new UsuarioController();

            //inserindo o usuario
            bool resultado = excluiUsuario.ExcluirUsuario(usuarios);

            if (resultado)
            {
                MessageBox.Show("Usuario excluido com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possivel excluir o usuario.");
            }

            AtualizaDataGrid();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load_1(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pegando os dados do formulario
            string senha = txtAlterarSenha.Text;

            //para excluir a linha
            string usuarios = Convert.ToString(dgvUsuario.SelectedRows[0].Cells[0].Value);

            //chamando a classe
            UsuarioController alterarSenha = new UsuarioController();

            //inserindo o usuario
            bool resultado = alterarSenha.AlterarSenha(senha, usuarios);

            if (resultado)
            {
                MessageBox.Show("Senha alterada com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possivel alterar a senha.");
            }

            AtualizaDataGrid();
        }
    }
}
