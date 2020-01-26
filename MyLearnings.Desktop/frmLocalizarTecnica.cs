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
    public partial class frmLocalizarTecnica : Form
    {
        public string operacao;

        public frmCadastroTecnica formQueChamou { get; set; }

        public frmLocalizarTecnica()
        {
            InitializeComponent();
        }

        private void btnLocalizaTec_Click(object sender, EventArgs e)
        {
                Tecnica tecnica = new Tecnica();
                tecnica.Nome = txtLocalizaTec.Text;
                TecnicaRegrasDeNegocio tecnicaRegras = new TecnicaRegrasDeNegocio();
                List<Tecnica> lista = new List<Tecnica>();

                lista = tecnicaRegras.BuscarTecnica(tecnica);

                dgvLocalizaTec.DataSource = lista;           
        }

        private void frmLocalizarTecnica_Load(object sender, EventArgs e)
        {
            //btnLocalizaTec_Click(sender, e);
            //dgvLocalizaTec.Columns[1].Width = 46;
            //dgvLocalizaTec.Columns[1].HeaderText = "Nome Técnica";
            //dgvLocalizaTec.Columns[1].Width = 250;
            //dgvLocalizaTec.Columns[2].Width = 250;
        }

        private void dgvLocalizaTec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvLocalizaTec.CurrentRow.Cells["ID"].Value.ToString(); // criando uma variável e passando para ela a grid, lendo a linha atual, da célula ID
            formQueChamou.txtIdTec.Text = id; // passando para o parâmetro form no campo Id o que contém na variável
            string nome = dgvLocalizaTec.CurrentRow.Cells["NOME"].Value.ToString();
            formQueChamou.txtNomeTec.Text = nome;
            string tempociclo = dgvLocalizaTec.CurrentRow.Cells["TEMPOCICLO"].Value.ToString();
            formQueChamou.txtTempoCiclo.Text = tempociclo;
            string descurto = dgvLocalizaTec.CurrentRow.Cells["DESCCURTO"].Value.ToString();
            formQueChamou.txtDescCurto.Text = descurto;
            string desclongo = dgvLocalizaTec.CurrentRow.Cells["DESCLONGO"].Value.ToString();
            formQueChamou.txtDescLongo.Text = desclongo;
            string datacadastro = dgvLocalizaTec.CurrentRow.Cells["DATACADASTRO"].Value.ToString();
            formQueChamou.mskDataCadastro.Text = datacadastro;
            string idusucadastro = dgvLocalizaTec.CurrentRow.Cells["IDUSUARIOCADASTRO"].Value?.ToString();
            formQueChamou.txtIdUsuCadastro.Text = idusucadastro;
            string idusualteracao = dgvLocalizaTec.CurrentRow.Cells["IDUSUARIOALTERACAO"].Value?.ToString();
            formQueChamou.txtIdUsuAlteracao.Text = idusualteracao;
            this.Hide(); //ocultando (?)
        }
    }
}
