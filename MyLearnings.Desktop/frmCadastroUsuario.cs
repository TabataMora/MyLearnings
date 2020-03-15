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
using MyLearnings.AcessoADados;
using MyLearnings.AcessoADados.AcessoEntidades;

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
                btnLocalizar.Enabled = true;
                txtEmail.Enabled = false;
                txtSenha.Enabled = false;
                txtUsuario.Enabled = false;
            }
            if(op == 2)
            {
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;
                btnLocalizar.Enabled = false;
                txtUsuario.ReadOnly = false;
                txtSenha.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtSenha.Enabled = true;
                txtEmail.Enabled = true;
                txtUsuario.Enabled = true;
            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;
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

            txtUsuario.Focus();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioRegrasDeNegocio usuarioRegras = new UsuarioRegrasDeNegocio();

                if (this.operacao == "Inserir")
                {
                    Usuario usuario = new Usuario();

                    usuario.Nome = txtUsuario.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtSenha.Text;

                    usuarioRegras.Incluir(usuario);

                    txtIdUsuario.Text = usuario.Id.ToString();

                    MessageBox.Show("Cadastro salvo com sucesso! " + usuario.Id.ToString());                 
                }
                if (this.operacao == "Alterar" && txtIdUsuario.Text != null)
                {                  
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(txtIdUsuario.Text);
                    usuario.Nome = txtUsuario.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtSenha.Text;
                    //alterar usuário           
                    usuarioRegras.Alterar(usuario/*id: Convert.ToInt32(txtIdUsuario.Text), nome: txtUsuario.Text*/);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
            }
            catch (Exception)
            {
                throw;
            }

            this.LimpaTela();
            this.AlteraBotoes(1);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {         
            this.operacao = "Alterar";
            this.AlteraBotoes(2);

            txtUsuario.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    UsuarioRegrasDeNegocio usuarioRegrasDeNegocio = new UsuarioRegrasDeNegocio();
                    usuarioRegrasDeNegocio.Excluir(Convert.ToInt32(txtIdUsuario.Text));
                    this.LimpaTela();
                    this.AlteraBotoes(1);

                    MessageBox.Show("Registro excluído com sucesso!");
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir esse registro. \nO registro está sendo utilizado em outro local.");
                this.AlteraBotoes(3);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
        }

        private void txtIdUsuario_Validated(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true; 
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmLocalizarUsuario frm = new frmLocalizarUsuario();
            frm.formQueChamou = this; // passando para o form do localizar a consulta
            frm.ShowDialog();
            this.AlteraBotoes(3);
        }
    }
}
