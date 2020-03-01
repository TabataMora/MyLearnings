namespace MyLearnings.Desktop
{
    partial class frmLocalizarResumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizarResumo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLocalizaResumo = new System.Windows.Forms.DataGridView();
            this.txtLocalizaResumo = new System.Windows.Forms.TextBox();
            this.btnLocalizaResumo = new System.Windows.Forms.Button();
            this.lblLocalizaResumo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizaResumo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLocalizaResumo);
            this.panel1.Controls.Add(this.txtLocalizaResumo);
            this.panel1.Controls.Add(this.btnLocalizaResumo);
            this.panel1.Controls.Add(this.lblLocalizaResumo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 361);
            this.panel1.TabIndex = 5;
            // 
            // dgvLocalizaResumo
            // 
            this.dgvLocalizaResumo.AllowUserToAddRows = false;
            this.dgvLocalizaResumo.AllowUserToDeleteRows = false;
            this.dgvLocalizaResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalizaResumo.Location = new System.Drawing.Point(20, 68);
            this.dgvLocalizaResumo.Name = "dgvLocalizaResumo";
            this.dgvLocalizaResumo.ReadOnly = true;
            this.dgvLocalizaResumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalizaResumo.Size = new System.Drawing.Size(987, 279);
            this.dgvLocalizaResumo.TabIndex = 3;
            this.dgvLocalizaResumo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalizaResumo_CellContentClick);
            // 
            // txtLocalizaResumo
            // 
            this.txtLocalizaResumo.Location = new System.Drawing.Point(20, 31);
            this.txtLocalizaResumo.Name = "txtLocalizaResumo";
            this.txtLocalizaResumo.Size = new System.Drawing.Size(926, 20);
            this.txtLocalizaResumo.TabIndex = 1;
            // 
            // btnLocalizaResumo
            // 
            this.btnLocalizaResumo.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizaResumo.Image")));
            this.btnLocalizaResumo.Location = new System.Drawing.Point(964, 19);
            this.btnLocalizaResumo.Name = "btnLocalizaResumo";
            this.btnLocalizaResumo.Size = new System.Drawing.Size(43, 43);
            this.btnLocalizaResumo.TabIndex = 2;
            this.btnLocalizaResumo.UseVisualStyleBackColor = true;
            this.btnLocalizaResumo.Click += new System.EventHandler(this.btnLocalizaResumo_Click);
            // 
            // lblLocalizaResumo
            // 
            this.lblLocalizaResumo.AutoSize = true;
            this.lblLocalizaResumo.Location = new System.Drawing.Point(17, 15);
            this.lblLocalizaResumo.Name = "lblLocalizaResumo";
            this.lblLocalizaResumo.Size = new System.Drawing.Size(155, 13);
            this.lblLocalizaResumo.TabIndex = 0;
            this.lblLocalizaResumo.Text = "Pesquisar Resumo Por Assunto";
            // 
            // frmLocalizarResumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 385);
            this.Controls.Add(this.panel1);
            this.Name = "frmLocalizarResumo";
            this.Text = "Localizar Resumo";
            this.Load += new System.EventHandler(this.frmLocalizarResumo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizaResumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLocalizaResumo;
        private System.Windows.Forms.TextBox txtLocalizaResumo;
        private System.Windows.Forms.Button btnLocalizaResumo;
        private System.Windows.Forms.Label lblLocalizaResumo;
    }
}