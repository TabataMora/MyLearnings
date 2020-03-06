namespace MyLearnings.Desktop
{
    partial class frmCadastroTecnica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroTecnica));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskDataAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.mskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtIdUsuAlteracao = new System.Windows.Forms.TextBox();
            this.txtIdUsuCadastro = new System.Windows.Forms.TextBox();
            this.txtDescLongo = new System.Windows.Forms.TextBox();
            this.txtDescCurto = new System.Windows.Forms.TextBox();
            this.txtTempoCiclo = new System.Windows.Forms.TextBox();
            this.chkPadrao = new System.Windows.Forms.CheckBox();
            this.txtNomeTec = new System.Windows.Forms.TextBox();
            this.txtIdTec = new System.Windows.Forms.TextBox();
            this.lblDtAlteracao = new System.Windows.Forms.Label();
            this.lblDtUsuAlteracao = new System.Windows.Forms.Label();
            this.lblIdUsuCadastro = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblDescLongo = new System.Windows.Forms.Label();
            this.lblDesCurto = new System.Windows.Forms.Label();
            this.lblTCiclo = new System.Windows.Forms.Label();
            this.lblNomeTecnica = new System.Windows.Forms.Label();
            this.lblIdTenica = new System.Windows.Forms.Label();
            this.toolTipMeusBotoes = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.mskDataAlteracao);
            this.panel1.Controls.Add(this.btnLocalizar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.mskDataCadastro);
            this.panel1.Controls.Add(this.txtIdUsuAlteracao);
            this.panel1.Controls.Add(this.txtIdUsuCadastro);
            this.panel1.Controls.Add(this.txtDescLongo);
            this.panel1.Controls.Add(this.txtDescCurto);
            this.panel1.Controls.Add(this.txtTempoCiclo);
            this.panel1.Controls.Add(this.chkPadrao);
            this.panel1.Controls.Add(this.txtNomeTec);
            this.panel1.Controls.Add(this.txtIdTec);
            this.panel1.Controls.Add(this.lblDtAlteracao);
            this.panel1.Controls.Add(this.lblDtUsuAlteracao);
            this.panel1.Controls.Add(this.lblIdUsuCadastro);
            this.panel1.Controls.Add(this.lblDtCadastro);
            this.panel1.Controls.Add(this.lblDescLongo);
            this.panel1.Controls.Add(this.lblDesCurto);
            this.panel1.Controls.Add(this.lblTCiclo);
            this.panel1.Controls.Add(this.lblNomeTecnica);
            this.panel1.Controls.Add(this.lblIdTenica);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 361);
            this.panel1.TabIndex = 0;
            // 
            // mskDataAlteracao
            // 
            this.mskDataAlteracao.Enabled = false;
            this.mskDataAlteracao.Location = new System.Drawing.Point(450, 223);
            this.mskDataAlteracao.Mask = "00/00/0000 00:00";
            this.mskDataAlteracao.Name = "mskDataAlteracao";
            this.mskDataAlteracao.ReadOnly = true;
            this.mskDataAlteracao.Size = new System.Drawing.Size(100, 20);
            this.mskDataAlteracao.TabIndex = 47;
            this.mskDataAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(101, 271);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(80, 78);
            this.btnLocalizar.TabIndex = 43;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(477, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 78);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(287, 271);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 78);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(194, 271);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 78);
            this.btnAlterar.TabIndex = 45;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(381, 271);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 78);
            this.btnSalvar.TabIndex = 41;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.Location = new System.Drawing.Point(10, 271);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(80, 78);
            this.btnInserir.TabIndex = 40;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // mskDataCadastro
            // 
            this.mskDataCadastro.Enabled = false;
            this.mskDataCadastro.Location = new System.Drawing.Point(447, 32);
            this.mskDataCadastro.Mask = "00/00/0000 00:00";
            this.mskDataCadastro.Name = "mskDataCadastro";
            this.mskDataCadastro.ReadOnly = true;
            this.mskDataCadastro.Size = new System.Drawing.Size(99, 20);
            this.mskDataCadastro.TabIndex = 39;
            this.mskDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdUsuAlteracao
            // 
            this.txtIdUsuAlteracao.Enabled = false;
            this.txtIdUsuAlteracao.Location = new System.Drawing.Point(309, 223);
            this.txtIdUsuAlteracao.Name = "txtIdUsuAlteracao";
            this.txtIdUsuAlteracao.ReadOnly = true;
            this.txtIdUsuAlteracao.Size = new System.Drawing.Size(135, 20);
            this.txtIdUsuAlteracao.TabIndex = 37;
            // 
            // txtIdUsuCadastro
            // 
            this.txtIdUsuCadastro.Location = new System.Drawing.Point(163, 223);
            this.txtIdUsuCadastro.Name = "txtIdUsuCadastro";
            this.txtIdUsuCadastro.ReadOnly = true;
            this.txtIdUsuCadastro.Size = new System.Drawing.Size(134, 20);
            this.txtIdUsuCadastro.TabIndex = 35;
            this.txtIdUsuCadastro.Validated += new System.EventHandler(this.txtIdUsuCadastro_Validated);
            // 
            // txtDescLongo
            // 
            this.txtDescLongo.Location = new System.Drawing.Point(10, 223);
            this.txtDescLongo.Name = "txtDescLongo";
            this.txtDescLongo.ReadOnly = true;
            this.txtDescLongo.Size = new System.Drawing.Size(141, 20);
            this.txtDescLongo.TabIndex = 33;
            // 
            // txtDescCurto
            // 
            this.txtDescCurto.Location = new System.Drawing.Point(10, 176);
            this.txtDescCurto.Name = "txtDescCurto";
            this.txtDescCurto.ReadOnly = true;
            this.txtDescCurto.Size = new System.Drawing.Size(136, 20);
            this.txtDescCurto.TabIndex = 32;
            // 
            // txtTempoCiclo
            // 
            this.txtTempoCiclo.Location = new System.Drawing.Point(10, 129);
            this.txtTempoCiclo.Name = "txtTempoCiclo";
            this.txtTempoCiclo.ReadOnly = true;
            this.txtTempoCiclo.Size = new System.Drawing.Size(136, 20);
            this.txtTempoCiclo.TabIndex = 31;
            // 
            // chkPadrao
            // 
            this.chkPadrao.AutoSize = true;
            this.chkPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPadrao.Location = new System.Drawing.Point(260, 32);
            this.chkPadrao.Name = "chkPadrao";
            this.chkPadrao.Size = new System.Drawing.Size(66, 17);
            this.chkPadrao.TabIndex = 30;
            this.chkPadrao.Text = "Padrão";
            this.chkPadrao.UseVisualStyleBackColor = true;
            // 
            // txtNomeTec
            // 
            this.txtNomeTec.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNomeTec.Location = new System.Drawing.Point(10, 76);
            this.txtNomeTec.Name = "txtNomeTec";
            this.txtNomeTec.ReadOnly = true;
            this.txtNomeTec.Size = new System.Drawing.Size(540, 20);
            this.txtNomeTec.TabIndex = 29;
            // 
            // txtIdTec
            // 
            this.txtIdTec.Enabled = false;
            this.txtIdTec.Location = new System.Drawing.Point(10, 33);
            this.txtIdTec.Name = "txtIdTec";
            this.txtIdTec.ReadOnly = true;
            this.txtIdTec.Size = new System.Drawing.Size(136, 20);
            this.txtIdTec.TabIndex = 28;
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(447, 206);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(110, 13);
            this.lblDtAlteracao.TabIndex = 27;
            this.lblDtAlteracao.Text = "Data de Alteração";
            // 
            // lblDtUsuAlteracao
            // 
            this.lblDtUsuAlteracao.AutoSize = true;
            this.lblDtUsuAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtUsuAlteracao.Location = new System.Drawing.Point(306, 206);
            this.lblDtUsuAlteracao.Name = "lblDtUsuAlteracao";
            this.lblDtUsuAlteracao.Size = new System.Drawing.Size(141, 13);
            this.lblDtUsuAlteracao.TabIndex = 26;
            this.lblDtUsuAlteracao.Text = "Id Usuário de Alteração";
            // 
            // lblIdUsuCadastro
            // 
            this.lblIdUsuCadastro.AutoSize = true;
            this.lblIdUsuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuCadastro.Location = new System.Drawing.Point(160, 206);
            this.lblIdUsuCadastro.Name = "lblIdUsuCadastro";
            this.lblIdUsuCadastro.Size = new System.Drawing.Size(137, 13);
            this.lblIdUsuCadastro.TabIndex = 25;
            this.lblIdUsuCadastro.Text = "Id Usuário de Cadastro";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(444, 16);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(106, 13);
            this.lblDtCadastro.TabIndex = 24;
            this.lblDtCadastro.Text = "Data do Cadastro";
            // 
            // lblDescLongo
            // 
            this.lblDescLongo.AutoSize = true;
            this.lblDescLongo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescLongo.Location = new System.Drawing.Point(7, 206);
            this.lblDescLongo.Name = "lblDescLongo";
            this.lblDescLongo.Size = new System.Drawing.Size(144, 13);
            this.lblDescLongo.TabIndex = 23;
            this.lblDescLongo.Text = "Tempo Descanso Longo";
            // 
            // lblDesCurto
            // 
            this.lblDesCurto.AutoSize = true;
            this.lblDesCurto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesCurto.Location = new System.Drawing.Point(7, 159);
            this.lblDesCurto.Name = "lblDesCurto";
            this.lblDesCurto.Size = new System.Drawing.Size(139, 13);
            this.lblDesCurto.TabIndex = 22;
            this.lblDesCurto.Text = "Tempo Descanso Curto";
            // 
            // lblTCiclo
            // 
            this.lblTCiclo.AutoSize = true;
            this.lblTCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCiclo.Location = new System.Drawing.Point(9, 113);
            this.lblTCiclo.Name = "lblTCiclo";
            this.lblTCiclo.Size = new System.Drawing.Size(95, 13);
            this.lblTCiclo.TabIndex = 21;
            this.lblTCiclo.Text = "Tempo do Ciclo";
            // 
            // lblNomeTecnica
            // 
            this.lblNomeTecnica.AutoSize = true;
            this.lblNomeTecnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTecnica.Location = new System.Drawing.Point(7, 60);
            this.lblNomeTecnica.Name = "lblNomeTecnica";
            this.lblNomeTecnica.Size = new System.Drawing.Size(39, 13);
            this.lblNomeTecnica.TabIndex = 19;
            this.lblNomeTecnica.Text = "Nome";
            // 
            // lblIdTenica
            // 
            this.lblIdTenica.AutoSize = true;
            this.lblIdTenica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTenica.Location = new System.Drawing.Point(7, 16);
            this.lblIdTenica.Name = "lblIdTenica";
            this.lblIdTenica.Size = new System.Drawing.Size(18, 13);
            this.lblIdTenica.TabIndex = 18;
            this.lblIdTenica.Text = "Id";
            // 
            // frmCadastroTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(588, 385);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastroTecnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro da Técnica";
            this.Load += new System.EventHandler(this.frmCadastroTecnica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDtAlteracao;
        private System.Windows.Forms.Label lblDtUsuAlteracao;
        private System.Windows.Forms.Label lblIdUsuCadastro;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label lblDescLongo;
        private System.Windows.Forms.Label lblDesCurto;
        private System.Windows.Forms.Label lblTCiclo;
        private System.Windows.Forms.Label lblNomeTecnica;
        private System.Windows.Forms.Label lblIdTenica;
        private System.Windows.Forms.CheckBox chkPadrao;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ToolTip toolTipMeusBotoes;
        public System.Windows.Forms.TextBox txtIdTec;
        public System.Windows.Forms.TextBox txtIdUsuAlteracao;
        public System.Windows.Forms.TextBox txtIdUsuCadastro;
        public System.Windows.Forms.TextBox txtDescLongo;
        public System.Windows.Forms.TextBox txtDescCurto;
        public System.Windows.Forms.TextBox txtTempoCiclo;
        public System.Windows.Forms.TextBox txtNomeTec;
        public System.Windows.Forms.MaskedTextBox mskDataCadastro;
        public System.Windows.Forms.MaskedTextBox mskDataAlteracao;
    }
}