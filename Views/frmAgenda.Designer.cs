namespace ProjetoAgenda.Views
{
    partial class frmAgenda
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
            groupBox1 = new GroupBox();
            cmbCategoria = new ComboBox();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            dgvContatos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 279);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "adicionar contato";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(19, 161);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(299, 23);
            cmbCategoria.TabIndex = 7;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(134, 217);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(90, 32);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(244, 217);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 32);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(19, 217);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(90, 32);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 117);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "categoria";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 56);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(299, 37);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "contato";
            // 
            // dgvContatos
            // 
            dgvContatos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(392, 23);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.Size = new Size(405, 268);
            dgvContatos.TabIndex = 1;
            dgvContatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(834, 323);
            Controls.Add(dgvContatos);
            Controls.Add(groupBox1);
            Name = "frmAgenda";
            Text = "frmAgenda";
            Load += frmAgenda_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCadastrar;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnAlterar;
        private Button btnExcluir;
        private ComboBox cmbCategoria;
        private DataGridView dgvContatos;
    }
}