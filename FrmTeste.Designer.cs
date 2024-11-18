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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(181, 3);
            button1.Name = "button1";
            button1.Size = new Size(420, 207);
            button1.TabIndex = 0;
            button1.Text = "NÃO CLIQUE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTeste2
            // 
            btnTeste2.BackColor = Color.LawnGreen;
            btnTeste2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeste2.Location = new Point(181, 231);
            btnTeste2.Name = "btnTeste2";
            btnTeste2.Size = new Size(420, 207);
            btnTeste2.TabIndex = 1;
            btnTeste2.Text = "NÃO CLIQUE";
            btnTeste2.UseVisualStyleBackColor = false;
            btnTeste2.Click += btnTeste2_Click;
            // 
            // FrmTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTeste2);
            Controls.Add(button1);
            Name = "FrmTeste";
            Text = "FrmTeste";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnTeste2;
    }
}