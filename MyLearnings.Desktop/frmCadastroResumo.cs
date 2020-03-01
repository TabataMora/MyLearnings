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
    public partial class frmCadastroResumo : Form
    {
        public string operacao;
      
        public frmCadastroResumo()
        {
            InicializadorDoForm();
        }

        public frmCadastroResumo(int id)
        {
            InicializadorDoForm();
            txtlIdCiclo.Text = Convert.ToString(id);
        }

        private void InicializadorDoForm()
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
            txtIdResumo.Clear();
            txtResumo.Clear();
            txtSubAssunto.Clear();
            txtAssunto.Clear();
            txtlIdCiclo.Clear();
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
                
            }
            if (op == 2)
            {
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;
                btnLocalizar.Enabled = false;
                
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

        private void frmCadastroResumo_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ResumoRegrasDeNegocio resumoRegras = new ResumoRegrasDeNegocio();

            if (this.operacao == "Inserir")
            {
                Resumo resumo = new Resumo();

                resumo.Subassunto = txtSubAssunto.Text;
                resumo.Assunto = txtAssunto.Text;
                resumo.Texto = txtResumo.Text;
                resumo.IdCicloResumo = Convert.ToInt32(txtlIdCiclo?.Text);

                resumoRegras.Incluir(resumo);

                txtIdResumo.Text = resumo.Id.ToString();
              
                MessageBox.Show("Cadastro efetuado com sucesso! " + resumo.Id.ToString());

                LimpaTela();
            }
            if (this.operacao == "Alterar" && txtIdResumo.Text != null)
            {
                Resumo resumo = new Resumo();

                resumo.Subassunto = txtSubAssunto.Text;
                resumo.Assunto = txtAssunto.Text;
                resumo.Texto = txtResumo.Text;
                resumo.IdCicloResumo = Convert.ToInt32(txtIdResumo.Text);
                resumo.Id = Convert.ToInt32(txtIdResumo.Text);

                resumoRegras.Alterar(resumo);

                MessageBox.Show("Alteração efetuada com sucesso! " + resumo.Id.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    ResumoRegrasDeNegocio resumoRegrasDeNegocio = new ResumoRegrasDeNegocio();
                    resumoRegrasDeNegocio.Excluir(Convert.ToInt32(txtIdResumo.Text));
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.AlteraBotoes(2);

            txtAssunto.Enabled = true;
            txtSubAssunto.Enabled = true;
            txtResumo.Enabled = true;
            txtAssunto.ReadOnly = false;
            txtSubAssunto.ReadOnly = false;
            txtResumo.ReadOnly = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);

            txtAssunto.Enabled = true;
            txtResumo.Enabled = true;
            txtSubAssunto.Enabled = true;
            txtResumo.ReadOnly = true;
            txtAssunto.ReadOnly = true;
            txtSubAssunto.ReadOnly = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.AlteraBotoes(2);

            txtAssunto.ReadOnly = false;
            txtResumo.ReadOnly = false;
            txtSubAssunto.ReadOnly = false;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmLocalizarResumo frm = new frmLocalizarResumo();
            frm.formQueChamouResumo = this; // passando para o form do localizar a consulta
            frm.ShowDialog();
            this.AlteraBotoes(3);
        }
    }
}
