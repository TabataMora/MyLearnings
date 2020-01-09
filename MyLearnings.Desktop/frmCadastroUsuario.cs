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
using System.IO;

namespace MyLearnings.Desktop
{
    public partial class frmCadastroUsuario : Form
    {
        public string operacao;

        public frmCadastroUsuario()
        {
            InitializeComponent();

            toolTipMeusBotoes.SetToolTip(btnInserir, "Inserir Usuário");
            toolTipMeusBotoes.SetToolTip(btnSalvar, "Salvar Usuário");
            toolTipMeusBotoes.SetToolTip(btnAlterar, "Alterar Cadastro");
            toolTipMeusBotoes.SetToolTip(btnExcluir, "Excluir Usuário");
            toolTipMeusBotoes.SetToolTip(btnCancelar, "Cancelar Cadastro");
        }

        public void LimpaTela()
        {
            txtIdUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
            txtEmail.Clear();
        }

        public void AlteraBotoes(int op)
        {
             
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnInserir.Enabled = false;

            if(op == 1)
            {
                btnInserir.Enabled = true;
               
            }

            if(op == 2)
            {
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;
            }

            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
                btnAlterar.Enabled = true;
            }
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.AlteraBotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nome = txtUsuario.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;

                UsuarioRegrasDeNegocio usuarioRegras = new UsuarioRegrasDeNegocio();
             
                txtIdUsuario.Text = usuario.Id.ToString();

                if (this.operacao == "Inserir")
                {
                    usuarioRegras.Incluir(usuario);
                    MessageBox.Show("Cadastro salvo com sucesso!" + usuario.Id.ToString());                  
                }

                else
                {
                    //alterar usuário
                    usuario.Id = Convert.ToInt32(txtIdUsuario.Text);
                    usuarioRegras. //criar método para alterar no regras de negócio
                    
                }
                this.LimpaTela();
                this.AlteraBotoes(1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.AlteraBotoes(2);
        }
    }
}
