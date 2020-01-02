
using MyLearnings.Entidades.Entidades;
using MyLearnings.RegrasDeNegocio.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
