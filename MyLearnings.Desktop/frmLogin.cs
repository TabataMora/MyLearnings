
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

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal(); // se for verdadeiro a validação acima, abre o form principal.

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
                    frm.Close();
                }
                if (validado == true) //testando o retorno da validação
                {
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnEntrar_Click(sender, e);
        }
    }
}
