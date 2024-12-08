using ProjetoAgenda.Controller;
using ProjetoAgenda.VariableGlobal;
using ProjetoAgenda.Views;

namespace ProjetoAgenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void habilitarBotaoLogin()
        {
            if (txtUsuario.Text != "" && txtSenha.Text.Length >= 8)
            {
                //se o texto do usuario for diferente de vazio e a senha for maior ou igual 8, o botao de login habilita
                btnLogar.Enabled = true;
            }

            else
            {
                btnLogar.Enabled = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro formularioCadastro = new frmCadastro();
            formularioCadastro.ShowDialog();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;


            bool validacao = usuarioController.ValidarLogin(usuario, senha);

            if (validacao)
            {
                this.Hide();

                frmPrincipal formularioPrincipal = new frmPrincipal();
                formularioPrincipal.ShowDialog();

                UserSession.usuario = txtUsuario.Text;
                UserSession.senha = txtSenha.Text;
            }
            else
            {
                MessageBox.Show("entra com alguem que existe");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }

}

