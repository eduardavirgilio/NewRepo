namespace ProjetoAgenda
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTexto = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            txtSenha = new TextBox();
            btnLogar = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(39, 67);
            lblTexto.Margin = new Padding(4, 0, 4, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(173, 52);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(39, 128);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(580, 81);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 268);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 52);
            label1.TabIndex = 2;
            label1.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(39, 330);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(580, 81);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.Pink;
            btnLogar.Enabled = false;
            btnLogar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogar.Location = new Point(39, 483);
            btnLogar.Margin = new Padding(4, 5, 4, 5);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(277, 117);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "LOGAR";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Pink;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(343, 483);
            btnCadastrar.Margin = new Padding(4, 5, 4, 5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(277, 117);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(677, 687);
            Controls.Add(btnCadastrar);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(lblTexto);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private TextBox txtUsuario;
        private Label label1;
        private TextBox txtSenha;
        private Button btnLogar;
        private Button btnCadastrar;
    }
}
