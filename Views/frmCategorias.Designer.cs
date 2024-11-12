namespace ProjetoAgenda.Views
{
    partial class frmCategorias
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
            label1 = new Label();
            txtNome = new TextBox();
            btnCadastrar = new Button();
            button1 = new Button();
            dgvCategoria = new DataGridView();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 30);
            label1.TabIndex = 0;
            label1.Text = "DIGITE O NOME DA CATEGORIA";
            label1.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(11, 60);
            txtNome.Margin = new Padding(2);
            txtNome.MaxLength = 40;
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(374, 34);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Lavender;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(248, 116);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(137, 31);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(282, 437);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 3;
            button1.Text = "fechar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = Color.Pink;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(23, 170);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(347, 233);
            dgvCategoria.TabIndex = 4;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(23, 116);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(103, 31);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(405, 480);
            Controls.Add(btnExcluir);
            Controls.Add(dgvCategoria);
            Controls.Add(button1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnCadastrar;
        private Button button1;
        private DataGridView dgvCategoria;
        private Button btnExcluir;
    }
}