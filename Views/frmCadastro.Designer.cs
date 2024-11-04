namespace ProjetoAgenda
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            lblTexto = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            txtRepitaSenha = new TextBox();
            label5 = new Label();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            resources.ApplyResources(lblTexto, "lblTexto");
            lblTexto.Name = "lblTexto";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.Name = "txtNome";
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.Name = "txtUsuario";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txtSenha
            // 
            resources.ApplyResources(txtSenha, "txtSenha");
            txtSenha.Name = "txtSenha";
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txtRepitaSenha
            // 
            resources.ApplyResources(txtRepitaSenha, "txtRepitaSenha");
            txtRepitaSenha.Name = "txtRepitaSenha";
            txtRepitaSenha.TextChanged += txtRepitaSenha_TextChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // btnEntrar
            // 
            resources.ApplyResources(btnEntrar, "btnEntrar");
            btnEntrar.BackColor = Color.Pink;
            btnEntrar.Name = "btnEntrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(btnCadastrar, "btnCadastrar");
            btnCadastrar.BackColor = Color.Pink;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadastro
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(label5);
            Controls.Add(txtRepitaSenha);
            Controls.Add(label4);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(lblTexto);
            Name = "frmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtSenha;
        private Label label4;
        private TextBox txtRepitaSenha;
        private Label label5;
        private Button btnEntrar;
        private Button btnCadastrar;
    }
}