﻿using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           UsuarioController controleUsuario = new UsuarioController();

            //bool resultado = controleUsuario.ValidarLogin("alex", "12345678");
            bool resultado = controleUsuario.ValidarLogin("godo", "AlexLindo");
            MessageBox.Show(resultado.ToString());

            
        }
    }
}
