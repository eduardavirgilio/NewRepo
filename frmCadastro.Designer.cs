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
            lblTexto = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(21, 23);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(91, 34);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 50);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 133);
            label1.Name = "label1";
            label1.Size = new Size(115, 34);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 170);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(407, 50);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 234);
            label2.Name = "label2";
            label2.Size = new Size(130, 34);
            label2.TabIndex = 5;
            label2.Text = "Telefone";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 271);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(407, 50);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 341);
            label3.Name = "label3";
            label3.Size = new Size(91, 34);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 388);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(407, 50);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 455);
            label4.Name = "label4";
            label4.Size = new Size(200, 34);
            label4.TabIndex = 9;
            label4.Text = "Repita a senha";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(21, 492);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(407, 50);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 561);
            label5.Name = "label5";
            label5.Size = new Size(0, 34);
            label5.TabIndex = 11;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Pink;
            btnEntrar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(234, 584);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(194, 70);
            btnEntrar.TabIndex = 12;
            btnEntrar.Text = "CANCELAR";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Pink;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(21, 584);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(194, 70);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(472, 778);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblTexto);
            Name = "frmCadastro";
            Text = "frmCadastro";
            Load += frmCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button btnEntrar;
        private Button btnCadastrar;
    }
}