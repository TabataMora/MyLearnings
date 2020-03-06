namespace MyLearnings.Desktop
{
    partial class frmTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTempoCiclo = new System.Windows.Forms.Label();
            this.lblDescCurto = new System.Windows.Forms.Label();
            this.lblDescLongo = new System.Windows.Forms.Label();
            this.lblIdTecnica = new System.Windows.Forms.Label();
            this.cmbTecnica = new System.Windows.Forms.ComboBox();
            this.txtTempoCiclo = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtDescLongo = new System.Windows.Forms.TextBox();
            this.txtDescCurto = new System.Windows.Forms.TextBox();
            this.txtTempoTotal = new System.Windows.Forms.TextBox();
            this.chkTempoCiclo = new System.Windows.Forms.CheckBox();
            this.chkDescLongo = new System.Windows.Forms.CheckBox();
            this.chkDescCurto = new System.Windows.Forms.CheckBox();
            this.txtIdTec = new System.Windows.Forms.TextBox();
            this.lblIdTec = new System.Windows.Forms.Label();
            this.chkResumo = new System.Windows.Forms.CheckBox();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.lblResumo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(157, 120);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnStart.Size = new System.Drawing.Size(85, 53);
            this.btnStart.TabIndex = 13;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTempoCiclo
            // 
            this.lblTempoCiclo.AutoSize = true;
            this.lblTempoCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoCiclo.Location = new System.Drawing.Point(8, 71);
            this.lblTempoCiclo.Name = "lblTempoCiclo";
            this.lblTempoCiclo.Size = new System.Drawing.Size(95, 13);
            this.lblTempoCiclo.TabIndex = 0;
            this.lblTempoCiclo.Text = "Tempo do Ciclo";
            // 
            // lblDescCurto
            // 
            this.lblDescCurto.AutoSize = true;
            this.lblDescCurto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCurto.Location = new System.Drawing.Point(8, 120);
            this.lblDescCurto.Name = "lblDescCurto";
            this.lblDescCurto.Size = new System.Drawing.Size(97, 13);
            this.lblDescCurto.TabIndex = 1;
            this.lblDescCurto.Text = "Descanso Curto";
            // 
            // lblDescLongo
            // 
            this.lblDescLongo.AutoSize = true;
            this.lblDescLongo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescLongo.Location = new System.Drawing.Point(8, 168);
            this.lblDescLongo.Name = "lblDescLongo";
            this.lblDescLongo.Size = new System.Drawing.Size(102, 13);
            this.lblDescLongo.TabIndex = 2;
            this.lblDescLongo.Text = "Descanso Longo";
            // 
            // lblIdTecnica
            // 
            this.lblIdTecnica.AutoSize = true;
            this.lblIdTecnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTecnica.Location = new System.Drawing.Point(8, 18);
            this.lblIdTecnica.Name = "lblIdTecnica";
            this.lblIdTecnica.Size = new System.Drawing.Size(53, 13);
            this.lblIdTecnica.TabIndex = 6;
            this.lblIdTecnica.Text = "Técnica";
            // 
            // cmbTecnica
            // 
            this.cmbTecnica.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbTecnica.FormattingEnabled = true;
            this.cmbTecnica.Location = new System.Drawing.Point(13, 33);
            this.cmbTecnica.Name = "cmbTecnica";
            this.cmbTecnica.Size = new System.Drawing.Size(78, 21);
            this.cmbTecnica.TabIndex = 20;
            this.cmbTecnica.SelectionChangeCommitted += new System.EventHandler(this.cmbTecnica_SelectionChangeCommitted);
            // 
            // txtTempoCiclo
            // 
            this.txtTempoCiclo.Enabled = false;
            this.txtTempoCiclo.Location = new System.Drawing.Point(11, 88);
            this.txtTempoCiclo.Name = "txtTempoCiclo";
            this.txtTempoCiclo.Size = new System.Drawing.Size(43, 20);
            this.txtTempoCiclo.TabIndex = 21;
            // 
            // btnPause
            // 
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(257, 120);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(85, 53);
            this.btnPause.TabIndex = 22;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(357, 120);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 53);
            this.btnStop.TabIndex = 23;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtDescLongo
            // 
            this.txtDescLongo.Enabled = false;
            this.txtDescLongo.Location = new System.Drawing.Point(11, 184);
            this.txtDescLongo.Name = "txtDescLongo";
            this.txtDescLongo.Size = new System.Drawing.Size(43, 20);
            this.txtDescLongo.TabIndex = 24;
            // 
            // txtDescCurto
            // 
            this.txtDescCurto.Enabled = false;
            this.txtDescCurto.Location = new System.Drawing.Point(11, 136);
            this.txtDescCurto.Name = "txtDescCurto";
            this.txtDescCurto.Size = new System.Drawing.Size(43, 20);
            this.txtDescCurto.TabIndex = 25;
            // 
            // txtTempoTotal
            // 
            this.txtTempoTotal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtTempoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempoTotal.Location = new System.Drawing.Point(140, 18);
            this.txtTempoTotal.Name = "txtTempoTotal";
            this.txtTempoTotal.ReadOnly = true;
            this.txtTempoTotal.Size = new System.Drawing.Size(313, 61);
            this.txtTempoTotal.TabIndex = 10000;
            this.txtTempoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkTempoCiclo
            // 
            this.chkTempoCiclo.Checked = true;
            this.chkTempoCiclo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTempoCiclo.Location = new System.Drawing.Point(68, 85);
            this.chkTempoCiclo.Name = "chkTempoCiclo";
            this.chkTempoCiclo.Size = new System.Drawing.Size(29, 32);
            this.chkTempoCiclo.TabIndex = 10001;
            this.chkTempoCiclo.UseVisualStyleBackColor = true;
            this.chkTempoCiclo.CheckedChanged += new System.EventHandler(this.chkTempoCiclo_CheckedChanged);
            // 
            // chkDescLongo
            // 
            this.chkDescLongo.Location = new System.Drawing.Point(68, 184);
            this.chkDescLongo.Name = "chkDescLongo";
            this.chkDescLongo.Size = new System.Drawing.Size(29, 24);
            this.chkDescLongo.TabIndex = 10002;
            this.chkDescLongo.UseVisualStyleBackColor = true;
            this.chkDescLongo.CheckedChanged += new System.EventHandler(this.chkDescLongo_CheckedChanged);
            // 
            // chkDescCurto
            // 
            this.chkDescCurto.Location = new System.Drawing.Point(68, 136);
            this.chkDescCurto.Name = "chkDescCurto";
            this.chkDescCurto.Size = new System.Drawing.Size(29, 27);
            this.chkDescCurto.TabIndex = 10003;
            this.chkDescCurto.UseVisualStyleBackColor = true;
            this.chkDescCurto.CheckedChanged += new System.EventHandler(this.chkDescCurto_CheckedChanged);
            // 
            // txtIdTec
            // 
            this.txtIdTec.Enabled = false;
            this.txtIdTec.Location = new System.Drawing.Point(97, 33);
            this.txtIdTec.Name = "txtIdTec";
            this.txtIdTec.Size = new System.Drawing.Size(37, 20);
            this.txtIdTec.TabIndex = 10004;
            // 
            // lblIdTec
            // 
            this.lblIdTec.AutoSize = true;
            this.lblIdTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTec.Location = new System.Drawing.Point(97, 17);
            this.lblIdTec.Name = "lblIdTec";
            this.lblIdTec.Size = new System.Drawing.Size(18, 13);
            this.lblIdTec.TabIndex = 10005;
            this.lblIdTec.Text = "Id";
            // 
            // chkResumo
            // 
            this.chkResumo.Location = new System.Drawing.Point(68, 228);
            this.chkResumo.Name = "chkResumo";
            this.chkResumo.Size = new System.Drawing.Size(29, 24);
            this.chkResumo.TabIndex = 10008;
            this.chkResumo.UseVisualStyleBackColor = true;
            this.chkResumo.CheckedChanged += new System.EventHandler(this.chkResumo_CheckedChanged);
            // 
            // txtResumo
            // 
            this.txtResumo.Enabled = false;
            this.txtResumo.Location = new System.Drawing.Point(11, 228);
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(43, 20);
            this.txtResumo.TabIndex = 10007;
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(8, 212);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(52, 13);
            this.lblResumo.TabIndex = 10006;
            this.lblResumo.Text = "Resumo";
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(465, 255);
            this.Controls.Add(this.chkResumo);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.lblIdTec);
            this.Controls.Add(this.txtIdTec);
            this.Controls.Add(this.chkDescCurto);
            this.Controls.Add(this.chkDescLongo);
            this.Controls.Add(this.chkTempoCiclo);
            this.Controls.Add(this.txtTempoTotal);
            this.Controls.Add(this.txtDescCurto);
            this.Controls.Add(this.txtDescLongo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtTempoCiclo);
            this.Controls.Add(this.cmbTecnica);
            this.Controls.Add(this.lblIdTecnica);
            this.Controls.Add(this.lblDescLongo);
            this.Controls.Add(this.lblDescCurto);
            this.Controls.Add(this.lblTempoCiclo);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporizador";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTempoCiclo;
        private System.Windows.Forms.Label lblDescCurto;
        private System.Windows.Forms.Label lblDescLongo;
        private System.Windows.Forms.Label lblIdTecnica;
        private System.Windows.Forms.ComboBox cmbTecnica;
        private System.Windows.Forms.TextBox txtTempoCiclo;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtDescLongo;
        private System.Windows.Forms.TextBox txtDescCurto;
        private System.Windows.Forms.TextBox txtTempoTotal;
        private System.Windows.Forms.CheckBox chkTempoCiclo;
        private System.Windows.Forms.CheckBox chkDescLongo;
        private System.Windows.Forms.CheckBox chkDescCurto;
        private System.Windows.Forms.TextBox txtIdTec;
        private System.Windows.Forms.Label lblIdTec;
        private System.Windows.Forms.CheckBox chkResumo;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Label lblResumo;
    }
}