namespace ProjetoAgenda
{
    partial class FrmTeste
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
            button1 = new Button();
            btnTeste2 = new Button();
            botao1 = new Button();
            botao2 = new Button();
            texto = new TextBox();
            nome = new Button();
            textonome = new TextBox();
            clica = new Button();
            botaosenha = new Button();
            textBox1 = new TextBox();
            botaoclica = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(264, 12);
            button1.Name = "button1";
            button1.Size = new Size(239, 55);
            button1.TabIndex = 0;
            button1.Text = "NÃO CLIQUE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTeste2
            // 
            btnTeste2.BackColor = Color.LawnGreen;
            btnTeste2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeste2.Location = new Point(12, 12);
            btnTeste2.Name = "btnTeste2";
            btnTeste2.Size = new Size(246, 55);
            btnTeste2.TabIndex = 1;
            btnTeste2.Text = "NÃO CLIQUE";
            btnTeste2.UseVisualStyleBackColor = false;
            btnTeste2.Click += btnTeste2_Click;
            // 
            // botao1
            // 
            botao1.BackColor = Color.LemonChiffon;
            botao1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao1.Location = new Point(549, 198);
            botao1.Name = "botao1";
            botao1.Size = new Size(239, 120);
            botao1.TabIndex = 2;
            botao1.Text = "fodase";
            botao1.UseVisualStyleBackColor = false;
            botao1.Click += botao1_Click;
            // 
            // botao2
            // 
            botao2.BackColor = Color.LemonChiffon;
            botao2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao2.Location = new Point(549, 12);
            botao2.Name = "botao2";
            botao2.Size = new Size(239, 120);
            botao2.TabIndex = 3;
            botao2.Text = "tar";
            botao2.UseVisualStyleBackColor = false;
            botao2.Click += botao2_Click;
            // 
            // texto
            // 
            texto.Location = new Point(549, 153);
            texto.Name = "texto";
            texto.Size = new Size(239, 23);
            texto.TabIndex = 4;
            // 
            // nome
            // 
            nome.BackColor = Color.LemonChiffon;
            nome.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nome.Location = new Point(19, 93);
            nome.Name = "nome";
            nome.Size = new Size(239, 120);
            nome.TabIndex = 5;
            nome.Text = "nome";
            nome.UseVisualStyleBackColor = false;
            nome.Click += nome_Click;
            // 
            // textonome
            // 
            textonome.Location = new Point(19, 235);
            textonome.Name = "textonome";
            textonome.Size = new Size(239, 23);
            textonome.TabIndex = 6;
            // 
            // clica
            // 
            clica.BackColor = Color.LemonChiffon;
            clica.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clica.Location = new Point(19, 275);
            clica.Name = "clica";
            clica.Size = new Size(239, 120);
            clica.TabIndex = 7;
            clica.Text = "isso";
            clica.UseVisualStyleBackColor = false;
            clica.Click += clica_Click;
            // 
            // botaosenha
            // 
            botaosenha.BackColor = Color.LemonChiffon;
            botaosenha.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botaosenha.Location = new Point(281, 106);
            botaosenha.Name = "botaosenha";
            botaosenha.Size = new Size(239, 120);
            botaosenha.TabIndex = 8;
            botaosenha.Text = "SENHA";
            botaosenha.UseVisualStyleBackColor = false;
            botaosenha.Click += botaosenha_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 9;
            // 
            // botaoclica
            // 
            botaoclica.BackColor = Color.LemonChiffon;
            botaoclica.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botaoclica.Location = new Point(281, 275);
            botaoclica.Name = "botaoclica";
            botaoclica.Size = new Size(239, 120);
            botaoclica.TabIndex = 10;
            botaoclica.Text = "clica";
            botaoclica.UseVisualStyleBackColor = false;
            botaoclica.Click += botaoclica_Click;
            // 
            // FrmTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoclica);
            Controls.Add(textBox1);
            Controls.Add(botaosenha);
            Controls.Add(clica);
            Controls.Add(textonome);
            Controls.Add(nome);
            Controls.Add(texto);
            Controls.Add(botao2);
            Controls.Add(botao1);
            Controls.Add(btnTeste2);
            Controls.Add(button1);
            Name = "FrmTeste";
            Text = "FrmTeste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnTeste2;
        private Button botao1;
        private Button botao2;
        private TextBox texto;
        private Button nome;
        private TextBox textonome;
        private Button clica;
        private Button botaosenha;
        private TextBox textBox1;
        private Button botaoclica;
    }
}