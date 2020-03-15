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

        public frmCadastroTecnica formQueChamouTecnica { get; set; }

        public frmLocalizarTecnica()
        {
            InitializeComponent();
        }

        private void btnLocalizaTec_Click(object sender, EventArgs e)
        {
            Tecnica tecnica = new Tecnica();
            tecnica.Nome = txtLocalizaTec.Text;
            int id;
            int.TryParse(txtLocalizarTecId.Text, out id); //tentando converter, se não converter mantém o valor atual
            tecnica.Id = id;
            TecnicaRegrasDeNegocio tecnicaRegras = new TecnicaRegrasDeNegocio();
            List<Tecnica> lista = new List<Tecnica>();

            lista = tecnicaRegras.BuscarTecnica(tecnica);

            dgvLocalizaTec.DataSource = lista;

            txtLocalizarTecId.Clear();
            txtLocalizaTec.Clear();
        }

        private void frmLocalizarTecnica_Load(object sender, EventArgs e)
        {
            btnLocalizaTec_Click(sender, e);
            dgvLocalizaTec.Columns[0].Width = 49;
            dgvLocalizaTec.Columns[0].HeaderText = "Id Técnica";
            dgvLocalizaTec.Columns[1].Width = 125;
            dgvLocalizaTec.Columns[1].HeaderText = "Nome Técnica";
            dgvLocalizaTec.Columns[2].Width = 46;
            dgvLocalizaTec.Columns[2].HeaderText = "Padrão";
            dgvLocalizaTec.Columns[3].Width = 75;
            dgvLocalizaTec.Columns[3].HeaderText = "Tempo do Ciclo";
            dgvLocalizaTec.Columns[4].Width = 75;
            dgvLocalizaTec.Columns[4].HeaderText = "Tempo Descanso Curto";
            dgvLocalizaTec.Columns[5].Width = 75;
            dgvLocalizaTec.Columns[5].HeaderText = "Tempo Descanso Longo";
            dgvLocalizaTec.Columns[6].Width = 100;
            dgvLocalizaTec.Columns[6].HeaderText = "Data do Cadastro";
            dgvLocalizaTec.Columns[7].Width = 95;
            dgvLocalizaTec.Columns[7].HeaderText = "Id do Usuário Cadastro";
            dgvLocalizaTec.Columns[8].Width = 100;
            dgvLocalizaTec.Columns[8].HeaderText = "Data da Alteração";
            dgvLocalizaTec.Columns[9].Width = 95;
            dgvLocalizaTec.Columns[9].HeaderText = "Id do Usuário Alteração";
        }

        private void dgvLocalizaTec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvLocalizaTec.CurrentRow.Cells["ID"].Value.ToString(); // criando uma variável e passando para ela a grid, lendo a linha atual, da célula ID
            formQueChamouTecnica.txtIdTec.Text = id; // passando para o parâmetro form no campo Id o que contém na variável
            string nome = dgvLocalizaTec.CurrentRow.Cells["NOME"].Value.ToString();
            formQueChamouTecnica.txtNomeTec.Text = nome;
            string tempociclo = dgvLocalizaTec.CurrentRow.Cells["TEMPOCICLO"].Value.ToString();
            formQueChamouTecnica.txtTempoCiclo.Text = tempociclo;
            string descurto = dgvLocalizaTec.CurrentRow.Cells["DESCCURTO"].Value.ToString();
            formQueChamouTecnica.txtDescCurto.Text = descurto;
            string desclongo = dgvLocalizaTec.CurrentRow.Cells["DESCLONGO"].Value.ToString();
            formQueChamouTecnica.txtDescLongo.Text = desclongo;
            string datacadastro = dgvLocalizaTec.CurrentRow.Cells["DATACADASTRO"].Value.ToString();
            formQueChamouTecnica.mskDataCadastro.Text = datacadastro;
            string idusucadastro = dgvLocalizaTec.CurrentRow.Cells["IDUSUARIOCADASTRO"].Value?.ToString();
            formQueChamouTecnica.txtIdUsuCadastro.Text = idusucadastro;
            string datalteracao = dgvLocalizaTec.CurrentRow.Cells["DATAALTERACAO"].Value?.ToString();
            formQueChamouTecnica.mskDataAlteracao.Text = datalteracao;
            string idusualteracao = dgvLocalizaTec.CurrentRow.Cells["IDUSUARIOALTERACAO"].Value?.ToString();
            formQueChamouTecnica.txtIdUsuAlteracao.Text = idusualteracao;
            this.Hide(); //ocultando (?)
        }
    }
}
