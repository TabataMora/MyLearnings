namespace MyLearnings.Desktop
{
    partial class frmHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorico));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDataPesquisa = new System.Windows.Forms.Label();
            this.dataHistorico = new System.Windows.Forms.DateTimePicker();
            this.grdHistorico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::MyLearnings.Desktop.Properties.Resources._1490129321_rounded10_82180__2_;
            this.btnPesquisar.Location = new System.Drawing.Point(574, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(48, 47);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblDataPesquisa
            // 
            this.lblDataPesquisa.AutoSize = true;
            this.lblDataPesquisa.Location = new System.Drawing.Point(9, 9);
            this.lblDataPesquisa.Name = "lblDataPesquisa";
            this.lblDataPesquisa.Size = new System.Drawing.Size(91, 13);
            this.lblDataPesquisa.TabIndex = 2;
            this.lblDataPesquisa.Text = "Data de Pesquisa";
            // 
            // dataHistorico
            // 
            this.dataHistorico.Location = new System.Drawing.Point(12, 32);
            this.dataHistorico.Name = "dataHistorico";
            this.dataHistorico.Size = new System.Drawing.Size(215, 20);
            this.dataHistorico.TabIndex = 3;
            // 
            // grdHistorico
            // 
            this.grdHistorico.AllowUserToAddRows = false;
            this.grdHistorico.AllowUserToDeleteRows = false;
            this.grdHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorico.Location = new System.Drawing.Point(12, 58);
            this.grdHistorico.Name = "grdHistorico";
            this.grdHistorico.ReadOnly = true;
            this.grdHistorico.Size = new System.Drawing.Size(610, 380);
            this.grdHistorico.TabIndex = 4;
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.grdHistorico);
            this.Controls.Add(this.dataHistorico);
            this.Controls.Add(this.lblDataPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorico";
            this.Text = "Histórico";
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblDataPesquisa;
        private System.Windows.Forms.DateTimePicker dataHistorico;
        private System.Windows.Forms.DataGridView grdHistorico;
    }
}