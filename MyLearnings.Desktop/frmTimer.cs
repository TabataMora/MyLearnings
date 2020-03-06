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
using System.Timers;
using MyLearnings.Entidades;
using MyLearnings.RegrasDeNegocio;
using System.Media;

namespace MyLearnings.Desktop
{
    public partial class frmTimer : Form
    {
        #region VARIAVEIS PUBLICAS QUE EU USO PARA COMPARTILHAR VALORES
        int IdCicloAtual = 0;
        int id_tecnica = 0;
        int retornoDoIdEvento;
        int segundoselecionado = 0;
        #endregion

        #region VARIAVEIS DO FULKANO DE PATAL  PARA LTAL COISA
        int TempoTotalEmSegundos;
        int contador;
        int Horas;
        int Minutos;
        int Segundos;
        int Finalizado;
        #endregion

        public frmTimer()
        {
            InitializeComponent();

            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            timer.Stop();
        }

        public List<Tecnica> lista = new List<Tecnica>();

        private SoundPlayer Player = new SoundPlayer();

        private void frmTimer_Load(object sender, EventArgs e)
        {
            TecnicaRegrasDeNegocio tecnicaRegras = new TecnicaRegrasDeNegocio();

            lista = tecnicaRegras.BuscarTecnica(null);
            cmbTecnica.DataSource = lista;
            cmbTecnica.DisplayMember = "Nome";
            cmbTecnica.ValueMember = "Id";
            cmbTecnica.SelectedIndex = -1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                if (Finalizado == 1)
                {                   
                    return;
                }
                if (contador == 0)
                {                   
                    TimerFinalizado();
                    AlterarCicloEventoNoBanco();
                    return;
                }
            }

            contador = contador - 1;

            TimeSpan OutputTime = TimeSpan.FromSeconds(contador);

            string CompleteOutput = OutputTime.ToString(@"hh\:mm\:ss");
            txtTempoTotal.Text = CompleteOutput;
        }

        private void TimerPausadoPeloUsuario()
        {
            txtTempoTotal.Visible = false;

            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;

            timer.Stop();
            Finalizado = 0;
            contador = 0;
            TempoTotalEmSegundos = 0;
            return;
        }

        private void TimerFinalizado()
        {
            Finalizado = 1;

            txtTempoTotal.Visible = false;

            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;

            timer.Stop();
            timer.Enabled = false;
            return;
        }

        private void InicioTimer(int psegundos)
        {
            Minutos = psegundos / 60;
            Segundos = psegundos % 60;

            Horas = Minutos / 60;
            int minutosAdicionais = (Minutos % 60);
            Minutos = minutosAdicionais;

            // PRA VOCÊ SABER QUANTAS HORAS, QUANTOS MINUTOS E QUANTOS SEGUNDOS VOCÊ PRECISA FAZER A CONTA.
            // NA SUA TABELA GRAVA OS MINUTOS... ENTÃO VOCÊ PRECISA FAZER A CONTA... CADA 60 MINUTOS É UMA HORA...
            // A CADA MINUTO TEM 60 SEGUNDOS... É SIMPLES... DAI VOCÊ PREENCHE ESSAS VARIAVEIS...

            TempoTotalEmSegundos = ((Horas * 60 * 60) + (Minutos * 60) + Segundos);

            txtTempoTotal.Visible = true;
            contador = TempoTotalEmSegundos;

            TimeSpan OutputTime = TimeSpan.FromSeconds(TempoTotalEmSegundos);

            string CompleteOutput = OutputTime.ToString(@"hh\:mm\:ss");
            txtTempoTotal.Text = CompleteOutput;
            Finalizado = 0;
            timer.Start();
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnStart.Enabled = false;
            return;
        }

        private void PausarTimer()
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        private int InserirCicloNoBanco()
        {
            Ciclo ciclo = new Ciclo(id_tecnica, IdLogin.ObterIdLogado(), DateTime.Now, "EM ANDAMENTO");

            CicloRegrasDeNegocio cicloRegrasDeNegocio = new CicloRegrasDeNegocio();
            IdCicloAtual = cicloRegrasDeNegocio.Incluir(ciclo);

            return IdCicloAtual;
        }

        private int InserirCicloEvento()
        {
            CicloEvento cicloEvento = new CicloEvento(IdCicloAtual, 1, DateTime.Now);

            if (chkTempoCiclo.Checked)
            {
                cicloEvento.IdEvento = 1;
            }
            if (chkDescCurto.Checked)
            {
                cicloEvento.IdEvento = 2;
            }
            if (chkDescLongo.Checked)
            {
                cicloEvento.IdEvento = 3;
            }
            if (chkResumo.Checked)
            {
                cicloEvento.IdEvento = 4;
            }

            CicloEventoRegrasDeNegocio cicloEventoRegras = new CicloEventoRegrasDeNegocio();

            retornoDoIdEvento = cicloEventoRegras.Incluir(cicloEvento);

            return retornoDoIdEvento;
        }

        public int AlterarCicloEventoNoBanco()
        {
            CicloEvento cicloEvento = new CicloEvento(DateTime.Now);

            cicloEvento.Id = retornoDoIdEvento;
            if (cicloEvento.Id != 0)
            {
                CicloEventoRegrasDeNegocio cicloEventoRegras = new CicloEventoRegrasDeNegocio();

                var retorno = cicloEventoRegras.Alterar(cicloEvento);
            }           
            
            return cicloEvento.Id;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InicioTimer(psegundos: segundoselecionado);

            if (IdCicloAtual == 0)
            {
                InserirCicloNoBanco();
            }
            if (IdCicloAtual > 0)
            {
                InserirCicloEvento();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PausarTimer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TimerPausadoPeloUsuario();
            InicioTimer(psegundos: 0);

            try
            {
                this.Player.SoundLocation = @"C:\gitRepository\MyLearnings\MyLearnings.Desktop\Songs\alerta.wav";
                this.Player.PlayLooping();
                DialogResult d = MessageBox.Show("Tempo finalizado!", "Alerta", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void chkTempoCiclo_CheckedChanged(object sender, EventArgs e)
        {
            chkDescCurto.Checked = false;
            chkDescLongo.Checked = false;
            chkResumo.Checked = false;

            HoraQueAComboEChamado();
        }

        private void chkDescCurto_CheckedChanged(object sender, EventArgs e)
        {
            chkTempoCiclo.Checked = false;
            chkDescLongo.Checked = false;
            chkTempoCiclo.Checked = false;
            chkResumo.Checked = false;

            HoraQueAComboEChamado();
        }

        private void chkDescLongo_CheckedChanged(object sender, EventArgs e)
        {
            chkDescCurto.Checked = false;
            chkTempoCiclo.Checked = false;
            chkTempoCiclo.Checked = false;
            chkResumo.Checked = false;

            HoraQueAComboEChamado();
        }

        private void cmbTecnica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HoraQueAComboEChamado();
        }

        private void HoraQueAComboEChamado()
        {
            if (cmbTecnica.SelectedIndex >= 0)
            {
                id_tecnica = (int)cmbTecnica.SelectedValue;

                Tecnica tecnicaSelecionada = lista.Where(x => x.Id == id_tecnica).FirstOrDefault();
                txtTempoCiclo.Text = Convert.ToString(tecnicaSelecionada.TempoCiclo);
                txtDescCurto.Text = Convert.ToString(tecnicaSelecionada.DescCurto);
                txtDescLongo.Text = Convert.ToString(tecnicaSelecionada.DescLongo);
                txtIdTec.Text = Convert.ToString(tecnicaSelecionada.Id);

                if (chkTempoCiclo.Checked /*&& cmbTecnica != null*/)
                {
                    segundoselecionado = (int)tecnicaSelecionada.TempoCiclo * 60;
                }
                if (chkDescCurto.Checked/* && cmbTecnica != null*/)
                { 
                    segundoselecionado = (int)tecnicaSelecionada.DescCurto * 60;
                }
                if (chkDescLongo.Checked/* && cmbTecnica != null*/)
                {
                    segundoselecionado = (int)tecnicaSelecionada.DescLongo * 60;
                }
                else if (tecnicaSelecionada == null)
                {
                    MessageBox.Show("O tempo não está sendo informado!");
                }
            }
        }

        private void chkResumo_CheckedChanged(object sender, EventArgs e)
        {
            chkDescCurto.Checked = false;
            chkDescLongo.Checked = false;
            chkTempoCiclo.Checked = false;
            frmCadastroResumo frm = new frmCadastroResumo(IdCicloAtual);
            frm.Show();
        }
    }
}
