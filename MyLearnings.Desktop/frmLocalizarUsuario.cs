﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLearnings.Entidades.Entidades;
using MyLearnings.RegrasDeNegocio.RegrasDeNegocio;

namespace MyLearnings.Desktop
{
    public partial class frmLocalizarUsuario : Form
    { 
        public frmCadastroUsuario formQueChamou { get; set; } //paraêmtro para carregar a grid

        public frmLocalizarUsuario()
        {
            InitializeComponent();
        }

        private void btnLocalizaUsu_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtLocalizaUsu.Text;
            int id;
            int.TryParse(txtLocalizarId.Text, out id); //tentando converter, se não converter mantém o valor atual
            usuario.Id = id;
            UsuarioRegrasDeNegocio usuarioRegra = new UsuarioRegrasDeNegocio();
            List<Usuario> lista = new List<Usuario>();

            lista = usuarioRegra.BuscarUsuario(usuario);

            dgvLocalizaUsu.DataSource = lista;
            
            txtLocalizarId.Clear();
            txtLocalizaUsu.Clear();
        }

        private void frmLocalizarUsuario_Load(object sender, EventArgs e)
        {
            btnLocalizaUsu_Click(sender, e);
            dgvLocalizaUsu.Columns[0].Width = 46;
            dgvLocalizaUsu.Columns[0].HeaderText = "Id Usuário";
            dgvLocalizaUsu.Columns[1].HeaderText = "Nome do Usuário";
            dgvLocalizaUsu.Columns[1].Width = 200;
            dgvLocalizaUsu.Columns[2].Visible = false;
            dgvLocalizaUsu.Columns[3].HeaderText = "Email";
            dgvLocalizaUsu.Columns[3].Width = 200;
        }

        private void dgvLocalizaUsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvLocalizaUsu.CurrentRow.Cells["ID"].Value.ToString(); // criando uma variável e passando para ela a grid, lendo a linha atual, da célula ID
            formQueChamou.txtIdUsuario.Text =  id; // passando para o parâmetro form no campo Id o que contém na variável
            string nome = dgvLocalizaUsu.CurrentRow.Cells["NOME"].Value.ToString();
            formQueChamou.txtUsuario.Text = nome;
            string email = dgvLocalizaUsu.CurrentRow.Cells["EMAIL"].Value.ToString();
            formQueChamou.txtEmail.Text = email;
            this.Hide(); //ocultando (?)
        }

    }
}
