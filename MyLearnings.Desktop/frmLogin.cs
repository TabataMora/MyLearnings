
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
            try
            {
                Usuario usuario = new Usuario(nome: "Dkljnkljhgho", senha: "123456", email: "diego@hotmail.com");

                UsuarioRegrasDeNegocio usuarioRegrasDeNegocio = new UsuarioRegrasDeNegocio();
                usuarioRegrasDeNegocio.Incluir(usuario);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //string senhaDigitada = "marlene";
            //string senhaParaSalvarNoBanco = string.Empty;


            //Criptografia criptografia = new Criptografia();

            //senhaParaSalvarNoBanco = criptografia.CriptografarSenha(senhaDigitada);

            // Este sistema está sendo feito uma validação 

            string usuario = string.Empty; 
            string senhaDigitada = string.Empty;
            string senhaCadastrada = "049AD99D6785BFCF5E707E6C3461CBBA52667FD670B0774A215D0CDEEE89B42851E5B54EA30F2B1DA14453426B873FF9830E7C2AD7561278986B9DFFDBEF43C6";
            bool validado = false;

            if (txtUsuario.Text != string.Empty || txtSenha.Text != string.Empty) //validando se a variável está vazia, se não for vazia
            {
                senhaDigitada = txtSenha.Text; //passando a senha do txt para a variável
                usuario = txtUsuario.Text; 

                Criptografia criptografia = new Criptografia(); // instaciando a classe para poder usar o método de validação
                validado = criptografia.VerificarSenha(senhaDigitada, senhaCadastrada); // passando para a variável de validação o retorno do metódo true ou falso
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
