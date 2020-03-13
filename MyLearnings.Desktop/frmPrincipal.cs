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
    public partial class frmPrincipal : Form
    {
        public void FecharLogin()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Close();
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frm = new frmCadastroUsuario();
            frm.ShowDialog();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalizarUsuario frm = new frmLocalizarUsuario();
            frm.ShowDialog();
        }

        private void técnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTecnica frm = new frmCadastroTecnica();
            frm.ShowDialog();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimer frm = new frmTimer();
            frm.Show();
        }

        private void resumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroResumo frm = new frmCadastroResumo();
            frm.Show();
        }

        private void resumoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLocalizarResumo frm = new frmLocalizarResumo();
            frm.Show();
        }
    }
}
