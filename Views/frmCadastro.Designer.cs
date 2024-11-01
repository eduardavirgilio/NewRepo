﻿namespace ProjetoAgenda
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
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(24, 31);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(114, 42);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(24, 80);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(465, 65);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 177);
            label1.Name = "label1";
            label1.Size = new Size(145, 42);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(24, 227);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(465, 65);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 328);
            label3.Name = "label3";
            label3.Size = new Size(114, 42);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(24, 395);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(465, 65);
            txtSenha.TabIndex = 8;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 497);
            label4.Name = "label4";
            label4.Size = new Size(254, 42);
            label4.TabIndex = 9;
            label4.Text = "Repita a senha";
            // 
            // txtRepitaSenha
            // 
            txtRepitaSenha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRepitaSenha.Location = new Point(24, 561);
            txtRepitaSenha.Margin = new Padding(3, 4, 3, 4);
            txtRepitaSenha.Multiline = true;
            txtRepitaSenha.Name = "txtRepitaSenha";
            txtRepitaSenha.PasswordChar = '*';
            txtRepitaSenha.Size = new Size(465, 65);
            txtRepitaSenha.TabIndex = 10;
            txtRepitaSenha.TextChanged += txtRepitaSenha_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 748);
            label5.Name = "label5";
            label5.Size = new Size(0, 42);
            label5.TabIndex = 11;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Pink;
            btnEntrar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(267, 681);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(222, 93);
            btnEntrar.TabIndex = 12;
            btnEntrar.Text = "CANCELAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Pink;
            btnCadastrar.Enabled = false;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(24, 681);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(222, 93);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(539, 811);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCadastro";
            Text = "frmCadastro";
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