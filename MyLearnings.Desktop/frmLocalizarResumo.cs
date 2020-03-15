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
    public partial class frmLocalizarResumo : Form
    {
        public frmCadastroResumo formQueChamouResumo { get; set; }

        public frmLocalizarResumo()
        {
            InitializeComponent();
        }

        private void btnLocalizaResumo_Click(object sender, EventArgs e)
        {
            Resumo resumo = new Resumo();
            resumo.Assunto = txtLocalizaResumo.Text;
            int id;
            int.TryParse(txtLocalizaResumoId.Text, out id); //tentando converter, se não converter mantém o valor atual
            resumo.Id = id;
            ResumoRegrasDeNegocio tecnicaRegras = new ResumoRegrasDeNegocio();
            List<Resumo> lista = new List<Resumo>();

            lista = tecnicaRegras.BuscarResumo(resumo);

            dgvLocalizaResumo.DataSource = lista;

            txtLocalizaResumo.Clear();
            txtLocalizaResumoId.Clear();
        }

        private void frmLocalizarResumo_Load(object sender, EventArgs e)
        {
            btnLocalizaResumo_Click(sender, e);
            dgvLocalizaResumo.Columns[0].Width = 49;
            dgvLocalizaResumo.Columns[0].HeaderText = "Id Resumo";
            dgvLocalizaResumo.Columns[1].Width = 46;
            dgvLocalizaResumo.Columns[1].HeaderText = "Id Ciclo";
            dgvLocalizaResumo.Columns[2].Width = 125;
            dgvLocalizaResumo.Columns[2].HeaderText = "Assunto";
            dgvLocalizaResumo.Columns[3].Width = 125;
            dgvLocalizaResumo.Columns[3].HeaderText = "SubAssunto";
            dgvLocalizaResumo.Columns[4].Width = 675;
            dgvLocalizaResumo.Columns[4].HeaderText = "Resumo";
        }

        private void dgvLocalizaResumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvLocalizaResumo.CurrentRow.Cells["ID"].Value.ToString(); 
            formQueChamouResumo.txtIdResumo.Text = id; 
            string assunto = dgvLocalizaResumo.CurrentRow.Cells["ASSUNTO"].Value.ToString();
            formQueChamouResumo.txtAssunto.Text = assunto;
            string subassunto = dgvLocalizaResumo.CurrentRow.Cells["SUBASSUNTO"].Value?.ToString();
            formQueChamouResumo.txtSubAssunto.Text = subassunto;
            string idciclo = dgvLocalizaResumo.CurrentRow.Cells["IDCICLORESUMO"].Value?.ToString();
            formQueChamouResumo.txtlIdCiclo.Text = idciclo;
            string resumo = dgvLocalizaResumo.CurrentRow.Cells["TEXTO"].Value?.ToString();
            formQueChamouResumo.txtResumo.Text = resumo;         
            this.Hide(); //ocultando (?)
        }
    }
}
