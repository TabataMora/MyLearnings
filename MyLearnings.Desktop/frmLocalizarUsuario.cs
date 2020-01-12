using System;
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
        public frmLocalizarUsuario()
        {
            InitializeComponent();
        }

        private void btnLocalizaUsu_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtLocalizaUsu.Text;
            UsuarioRegrasDeNegocio usuarioRegra = new UsuarioRegrasDeNegocio();
            List<Usuario> lista = new List<Usuario>();

            lista = usuarioRegra.BuscarUsuario(usuario);

            dgvLocalizaUsu.DataSource = lista;
        }

        private void frmLocalizarUsuario_Load(object sender, EventArgs e)
        {
            btnLocalizaUsu_Click(sender, e);
            dgvLocalizaUsu.Columns[0].Width = 46;
            dgvLocalizaUsu.Columns[1].HeaderText = "Nome Usuário";
            dgvLocalizaUsu.Columns[1].Width = 250;
            dgvLocalizaUsu.Columns[2].Visible = false;
            dgvLocalizaUsu.Columns[3].Visible = false;
        }
    }
}
