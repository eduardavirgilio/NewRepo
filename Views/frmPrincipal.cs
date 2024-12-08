﻿using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ediuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias formularioPrincipal = new frmCategorias();
            formularioPrincipal.ShowDialog();


            UserSession.nome = lblBemvindo.Text;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios formularioUsuarios = new frmUsuarios();
            formularioUsuarios.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda formularioAgenda = new frmAgenda();
            formularioAgenda.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBemvindo.Text = $"Seja bem vindo(a), {UserSession.nome}!";
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin formularioLogin = new frmLogin();
            formularioLogin.ShowDialog();


        }
    }
}
