
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
            UsuarioRegrasDeNegocio usuarioRegras = new UsuarioRegrasDeNegocio(); //instanciando uma classe para usar o método
            bool validado = false;
            try
            {
                if (txtUsuario.Text != string.Empty || txtSenha.Text != string.Empty) //validando se a variável está vazia, se não for vazia
                {
                    validado = usuarioRegras.ValidaUsuario(txtUsuario.Text, senha: txtSenha.Text); // passando para a variável validado o que tem no usuário e senha digitados pelo usuário.
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos!");
                }

                if (validado == true) //testando o retorno da validação
                {
                    frmCadastroUsuario frm = new frmCadastroUsuario(); // se for verdadeiro a validação acima, abre o form principal.
                    frm.Show();
                }

                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
