using MyLearnings.Entidades.Entidades;
using MyLearnings.RegrasDeNegocio.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLearnings.Desktop
{
    public partial class frmCadastroTecnica : Form
    {
        public string operacao;

        public frmCadastroTecnica()
        {
            InitializeComponent();

            toolTipMeusBotoes.SetToolTip(btnInserir, "Inserir Técnica");
            toolTipMeusBotoes.SetToolTip(btnSalvar, "Salvar Técnica");
            toolTipMeusBotoes.SetToolTip(btnAlterar, "Alterar Técnica");
            toolTipMeusBotoes.SetToolTip(btnExcluir, "Excluir Técnica");
            toolTipMeusBotoes.SetToolTip(btnCancelar, "Cancelar Cadastro");
        }

        public void LimpaTela()
        {
            txtIdTec.Clear();
            txtNomeTec.Clear();
            txtDescCurto.Clear();
            txtDescLongo.Clear();
            txtTempoCiclo.Clear();
            chkPadrao.Checked = false;
            mskDataCadastro.Clear();
            mskDataAlteracao.Clear();
            txtIdUsuCadastro.Clear();
            txtIdUsuAlteracao.Clear();
        }

        public void AlteraBotoes(int op)
        {         
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnInserir.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
                txtNomeTec.ReadOnly = true;
                txtDescCurto.ReadOnly = true;
                txtDescLongo.ReadOnly = true;
                txtTempoCiclo.ReadOnly = true;
                txtIdUsuCadastro.ReadOnly = true;
                txtNomeTec.Enabled = false;
                txtDescCurto.Enabled = false;
                txtDescLongo.Enabled = false;
                txtTempoCiclo.Enabled = false;
                txtIdUsuCadastro.Enabled = false;

            }

            if (op == 2)
            {
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;
                btnLocalizar.Enabled = false;
                txtNomeTec.Enabled = true;
                txtDescCurto.Enabled = true;
                txtDescLongo.Enabled = true;
                txtTempoCiclo.Enabled = true;
                txtIdUsuCadastro.Enabled = true;
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

        private void frmCadastroTecnica_Load(object sender, EventArgs e)
        {
            mskDataCadastro.Text = DateTime.Now.ToString();
            mskDataAlteracao.Text = DateTime.Now.ToString();
            this.AlteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.AlteraBotoes(2);
            txtNomeTec.ReadOnly = false;
            txtDescCurto.ReadOnly = false;
            txtDescLongo.ReadOnly = false;
            txtTempoCiclo.ReadOnly = false;
            txtIdUsuCadastro.ReadOnly = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                TecnicaRegrasDeNegocio tecnicaRegras = new TecnicaRegrasDeNegocio();         

                if (this.operacao == "Inserir")
                {
                    Tecnica tecnica = new Tecnica();

                    mskDataCadastro.Text = DateTime.Now.ToString();
                    mskDataAlteracao.Text = DateTime.Now.ToString();
                    tecnica.Nome = txtNomeTec.Text;
                    tecnica.IdUsuarioCadastro = Convert.ToInt32(txtIdUsuCadastro.Text);
                    tecnica.TempoCiclo = Convert.ToInt32(txtTempoCiclo.Text);
                    tecnica.DescCurto = Convert.ToInt32(txtDescCurto.Text);
                    tecnica.DescLongo = Convert.ToInt32(txtDescLongo.Text);
                    tecnica.Padrao = chkPadrao.Checked == true ? "S" : "N";

                    tecnicaRegras.Incluir(tecnica);

                    txtIdTec.Text = tecnica.Id.ToString();

                    MessageBox.Show("Cadastro efetuado com sucesso! " + tecnica.Id.ToString());                  
                }

                if (this.operacao == "Alterar" && txtIdTec.Text != null)
                {
                    txtIdUsuAlteracao.ReadOnly = false;

                    Tecnica tecnica = new Tecnica();
                    tecnica.Nome = txtNomeTec.Text;
                    tecnica.IdUsuarioCadastro = Convert.ToInt32(txtIdUsuCadastro.Text);
                    tecnica.TempoCiclo = Convert.ToInt32(txtTempoCiclo.Text);
                    tecnica.DescCurto = Convert.ToInt32(txtDescCurto.Text);
                    tecnica.DescLongo = Convert.ToInt32(txtDescLongo.Text);
                    tecnica.Id = Convert.ToInt32(txtIdTec.Text);
                    tecnica.DataAlteracao = Convert.ToDateTime(mskDataAlteracao.Text);
                    tecnica.Padrao = chkPadrao.Checked == true ? "S" : "N";
                    tecnica.IdUsuarioAlteracao = IdLogin.IdLogado(IdUsuCadastro: Convert.ToInt32(txtIdUsuAlteracao.Text));
                    tecnicaRegras.Alterar(tecnica);

                    MessageBox.Show("Alteração efetuada com sucesso! " + tecnica.Id.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }

            this.LimpaTela();
            this.AlteraBotoes(1);
        } 

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    TecnicaRegrasDeNegocio tecnicaRegrasDeNegocio = new TecnicaRegrasDeNegocio();
                    tecnicaRegrasDeNegocio.Excluir(Convert.ToInt32(txtIdTec.Text));
                    this.LimpaTela();
                    this.AlteraBotoes(1);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNomeTec.ReadOnly = false;
            txtDescCurto.ReadOnly = false;
            txtDescLongo.ReadOnly = false;
            txtTempoCiclo.ReadOnly = false;
            txtIdUsuCadastro.ReadOnly = false;
            txtIdUsuAlteracao.ReadOnly = false;
            txtIdUsuCadastro.Enabled = false;
            
            this.operacao = "Alterar";
            this.AlteraBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmLocalizarTecnica frm = new frmLocalizarTecnica();
            frm.formQueChamou = this; // passando para o form do localizar a consulta
            frm.ShowDialog();
            this.AlteraBotoes(3);
        }

        private void txtIdUsuCadastro_Validated(object sender, EventArgs e)
        {
            UsuarioRegrasDeNegocio usuarioRegrasDeNegocio = new UsuarioRegrasDeNegocio();
            var usuario = usuarioRegrasDeNegocio.BuscaUsuarioPorId( Convert.ToInt32(txtIdUsuCadastro.Text));

            txtNomeUsu.Text = usuario.Nome;
        }   
    }
}   


