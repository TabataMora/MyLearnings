
using MyLearnings.Entidades.Auxiliares;
using MyLearnings.Entidades.Entidades;
using MyLearnings.RegrasDeNegocio.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLearnings.Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    Usuario usuario = new Usuario(nome: "Dkljnkljhgho", senha: "123456", email: "diego@hotmail.com");

            //    UsuarioRegrasDeNegocio usuarioRegrasDeNegocio = new UsuarioRegrasDeNegocio();
            //    usuarioRegrasDeNegocio.Incluir(usuario);


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioRegrasDeNegocio usuarioRegras = new UsuarioRegrasDeNegocio();
            bool validado = false;

            if (txtUsuario.Text != string.Empty || txtSenha.Text != string.Empty) //validando se a variável está vazia, se não for vazia
            {
                validado = usuarioRegras.ValidaUsuario(txtUsuario.Text, senha: txtSenha.Text);
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos!");
            }

            if (validado == true)
            {
                frmPrincipal frm = new frmPrincipal(); // se for verdadeiro a validação de cima, abre o form principal.
                frm.Show();
            }

            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos!");
            }



        }
    }
}
