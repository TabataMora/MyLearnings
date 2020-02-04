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
            this.lblTempoCiclo = new System.Windows.Forms.Label();
            this.lblDescCurto = new System.Windows.Forms.Label();
            this.lblDescLongo = new System.Windows.Forms.Label();
            this.lblIdTecnica = new System.Windows.Forms.Label();
            this.mskDescCurto = new System.Windows.Forms.MaskedTextBox();
            this.mskDescLongo = new System.Windows.Forms.MaskedTextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnTempoCiclo = new System.Windows.Forms.Button();
            this.btnDescCurto = new System.Windows.Forms.Button();
            this.btnDescLongo = new System.Windows.Forms.Button();
            this.cmbTecnica = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTempoCiclo
            // 
            this.lblTempoCiclo.AutoSize = true;
            this.lblTempoCiclo.Location = new System.Drawing.Point(12, 81);
            this.lblTempoCiclo.Name = "lblTempoCiclo";
            this.lblTempoCiclo.Size = new System.Drawing.Size(81, 13);
            this.lblTempoCiclo.TabIndex = 0;
            this.lblTempoCiclo.Text = "Tempo do Ciclo";
            // 
            // lblDescCurto
            // 
            this.lblDescCurto.AutoSize = true;
            this.lblDescCurto.Location = new System.Drawing.Point(12, 130);
            this.lblDescCurto.Name = "lblDescCurto";
            this.lblDescCurto.Size = new System.Drawing.Size(83, 13);
            this.lblDescCurto.TabIndex = 1;
            this.lblDescCurto.Text = "Descanso Curto";
            // 
            // lblDescLongo
            // 
            this.lblDescLongo.AutoSize = true;
            this.lblDescLongo.Location = new System.Drawing.Point(12, 178);
            this.lblDescLongo.Name = "lblDescLongo";
            this.lblDescLongo.Size = new System.Drawing.Size(88, 13);
            this.lblDescLongo.TabIndex = 2;
            this.lblDescLongo.Text = "Descanso Longo";
            // 
            // lblIdTecnica
            // 
            this.lblIdTecnica.AutoSize = true;
            this.lblIdTecnica.Location = new System.Drawing.Point(11, 24);
            this.lblIdTecnica.Name = "lblIdTecnica";
            this.lblIdTecnica.Size = new System.Drawing.Size(46, 13);
            this.lblIdTecnica.TabIndex = 6;
            this.lblIdTecnica.Text = "Técnica";
            // 
            // mskDescCurto
            // 
            this.mskDescCurto.Enabled = false;
            this.mskDescCurto.Location = new System.Drawing.Point(15, 146);
            this.mskDescCurto.Mask = "90:00";
            this.mskDescCurto.Name = "mskDescCurto";
            this.mskDescCurto.Size = new System.Drawing.Size(33, 20);
            this.mskDescCurto.TabIndex = 11;
            this.mskDescCurto.ValidatingType = typeof(System.DateTime);
            // 
            // mskDescLongo
            // 
            this.mskDescLongo.Enabled = false;
            this.mskDescLongo.Location = new System.Drawing.Point(15, 194);
            this.mskDescLongo.Mask = "90:00";
            this.mskDescLongo.Name = "mskDescLongo";
            this.mskDescLongo.Size = new System.Drawing.Size(33, 20);
            this.mskDescLongo.TabIndex = 12;
            this.mskDescLongo.ValidatingType = typeof(System.DateTime);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.Location = new System.Drawing.Point(199, 127);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnIniciar.Size = new System.Drawing.Size(117, 60);
            this.btnIniciar.TabIndex = 13;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(193, 57);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(126, 50);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "00:00";
            // 
            // btnTempoCiclo
            // 
            this.btnTempoCiclo.Image = ((System.Drawing.Image)(resources.GetObject("btnTempoCiclo.Image")));
            this.btnTempoCiclo.Location = new System.Drawing.Point(99, 85);
            this.btnTempoCiclo.Name = "btnTempoCiclo";
            this.btnTempoCiclo.Size = new System.Drawing.Size(43, 43);
            this.btnTempoCiclo.TabIndex = 15;
            this.btnTempoCiclo.UseVisualStyleBackColor = true;
            // 
            // btnDescCurto
            // 
            this.btnDescCurto.Image = ((System.Drawing.Image)(resources.GetObject("btnDescCurto.Image")));
            this.btnDescCurto.Location = new System.Drawing.Point(99, 132);
            this.btnDescCurto.Name = "btnDescCurto";
            this.btnDescCurto.Size = new System.Drawing.Size(43, 43);
            this.btnDescCurto.TabIndex = 18;
            this.btnDescCurto.UseVisualStyleBackColor = true;
            // 
            // btnDescLongo
            // 
            this.btnDescLongo.Image = ((System.Drawing.Image)(resources.GetObject("btnDescLongo.Image")));
            this.btnDescLongo.Location = new System.Drawing.Point(99, 178);
            this.btnDescLongo.Name = "btnDescLongo";
            this.btnDescLongo.Size = new System.Drawing.Size(43, 43);
            this.btnDescLongo.TabIndex = 19;
            this.btnDescLongo.UseVisualStyleBackColor = true;
            // 
            // cmbTecnica
            // 
            this.cmbTecnica.FormattingEnabled = true;
            this.cmbTecnica.Location = new System.Drawing.Point(15, 41);
            this.cmbTecnica.Name = "cmbTecnica";
            this.cmbTecnica.Size = new System.Drawing.Size(78, 21);
            this.cmbTecnica.TabIndex = 20;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 21;
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 243);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbTecnica);
            this.Controls.Add(this.btnDescLongo);
            this.Controls.Add(this.btnDescCurto);
            this.Controls.Add(this.btnTempoCiclo);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.mskDescLongo);
            this.Controls.Add(this.mskDescCurto);
            this.Controls.Add(this.lblIdTecnica);
            this.Controls.Add(this.lblDescLongo);
            this.Controls.Add(this.lblDescCurto);
            this.Controls.Add(this.lblTempoCiclo);
            this.Name = "frmTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempoCiclo;
        private System.Windows.Forms.Label lblDescCurto;
        private System.Windows.Forms.Label lblDescLongo;
        private System.Windows.Forms.Label lblIdTecnica;
        private System.Windows.Forms.MaskedTextBox mskDescCurto;
        private System.Windows.Forms.MaskedTextBox mskDescLongo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnTempoCiclo;
        private System.Windows.Forms.Button btnDescCurto;
        private System.Windows.Forms.Button btnDescLongo;
        private System.Windows.Forms.ComboBox cmbTecnica;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox1;
    }
}