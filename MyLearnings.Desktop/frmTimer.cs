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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }
        public List<Tecnica> lista = new List<Tecnica>();

        private void frmTimer_Load(object sender, EventArgs e)
        {
            TecnicaRegrasDeNegocio tecnicaRegras = new TecnicaRegrasDeNegocio();
            

            lista = tecnicaRegras.BuscarTecnica(null);

            cmbTecnica.DataSource = lista;
            cmbTecnica.DisplayMember = "Nome";
            cmbTecnica.ValueMember = "Id";
        }

        int tempo;
        int minuto;
        int segundo;

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            tempo = Convert.ToInt16(textBox1.Text);

            if (tempo >= 0)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;
            }
            else
            {
                minuto = 0;
                segundo = tempo;
            }

            lblTimer.Text = "0" + minuto + ":" + segundo;
            timer.Enabled = true;
          
            //Tecnica selecionada = lista.Where(l => l.Id ==  (int)cmbTecnica.SelectedValue).Single();

            //if (selecionada.TempoCiclo >= 60)
            //{
            //    selecionada.TempoCiclo = selecionada.TempoCiclo / 60;
            //}
            //selecionada.TempoCiclo = Convert.ToDecimal(textBox1.Text);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            segundo--;

            if(minuto > 0)
            {
                if(segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            lblTimer.Text = "0" + minuto + ":" + segundo;

            if(minuto == 0 && segundo == 0)
            {
                timer.Enabled = false;
            }
        }
    }
}
