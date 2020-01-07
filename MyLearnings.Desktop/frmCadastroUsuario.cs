using MyLearnings.Entidades.Entidades;
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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = txtUsuario.Text;
            usuario.Email = txtEmail.Text;
            usuario.Id = Convert.ToInt32(txtIdUsuario.Text);
            usuario.Senha = txtSenha.Text;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
