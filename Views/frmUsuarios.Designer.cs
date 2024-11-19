namespace ProjetoAgenda.Views
{
    partial class frmUsuarios
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
            dgvUsuario = new DataGridView();
            label1 = new Label();
            btnExcluir = new Button();
            button1 = new Button();
            gbSenha = new GroupBox();
            btnAlterar = new Button();
            txtAlterarSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            gbSenha.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuario
            // 
            dgvUsuario.BackgroundColor = Color.Pink;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(28, 55);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(233, 190);
            dgvUsuario.TabIndex = 5;
            dgvUsuario.CellContentClick += dgvUsuario_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 20);
            label1.TabIndex = 6;
            label1.Text = "ESCOLHA QUEM VOCE QUER EXCLUIR";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(28, 275);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(103, 31);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(158, 275);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 8;
            button1.Text = "fechar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gbSenha
            // 
            gbSenha.Controls.Add(btnAlterar);
            gbSenha.Controls.Add(txtAlterarSenha);
            gbSenha.Location = new Point(328, 92);
            gbSenha.Name = "gbSenha";
            gbSenha.Size = new Size(362, 128);
            gbSenha.TabIndex = 10;
            gbSenha.TabStop = false;
            gbSenha.Text = "Alterar senha";
            gbSenha.Enter += gbSenha_Enter;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.White;
            btnAlterar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(15, 80);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(331, 31);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar senha";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += button2_Click;
            // 
            // txtAlterarSenha
            // 
            txtAlterarSenha.Location = new Point(15, 27);
            txtAlterarSenha.Multiline = true;
            txtAlterarSenha.Name = "txtAlterarSenha";
            txtAlterarSenha.Size = new Size(331, 36);
            txtAlterarSenha.TabIndex = 0;
            txtAlterarSenha.TextChanged += txtAlterarSenha_TextChanged;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(739, 334);
            Controls.Add(gbSenha);
            Controls.Add(button1);
            Controls.Add(btnExcluir);
            Controls.Add(label1);
            Controls.Add(dgvUsuario);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuarios";
            Load += frmUsuarios_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            gbSenha.ResumeLayout(false);
            gbSenha.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuario;
        private Label label1;
        private Button btnExcluir;
        private Button button1;
        private GroupBox gbSenha;
        private Button btnAlterar;
        private TextBox txtAlterarSenha;
    }
}