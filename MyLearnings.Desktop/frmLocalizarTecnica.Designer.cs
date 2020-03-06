namespace MyLearnings.Desktop
{
    partial class frmLocalizarTecnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizarTecnica));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLocalizaTec = new System.Windows.Forms.DataGridView();
            this.txtLocalizaTec = new System.Windows.Forms.TextBox();
            this.btnLocalizaTec = new System.Windows.Forms.Button();
            this.lblLocalizaTec = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizaTec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.dgvLocalizaTec);
            this.panel1.Controls.Add(this.txtLocalizaTec);
            this.panel1.Controls.Add(this.btnLocalizaTec);
            this.panel1.Controls.Add(this.lblLocalizaTec);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 351);
            this.panel1.TabIndex = 4;
            // 
            // dgvLocalizaTec
            // 
            this.dgvLocalizaTec.AllowUserToAddRows = false;
            this.dgvLocalizaTec.AllowUserToDeleteRows = false;
            this.dgvLocalizaTec.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalizaTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalizaTec.Location = new System.Drawing.Point(10, 64);
            this.dgvLocalizaTec.Name = "dgvLocalizaTec";
            this.dgvLocalizaTec.ReadOnly = true;
            this.dgvLocalizaTec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalizaTec.Size = new System.Drawing.Size(476, 279);
            this.dgvLocalizaTec.TabIndex = 3;
            this.dgvLocalizaTec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalizaTec_CellContentClick);
            // 
            // txtLocalizaTec
            // 
            this.txtLocalizaTec.Location = new System.Drawing.Point(10, 27);
            this.txtLocalizaTec.Name = "txtLocalizaTec";
            this.txtLocalizaTec.Size = new System.Drawing.Size(427, 20);
            this.txtLocalizaTec.TabIndex = 1;
            // 
            // btnLocalizaTec
            // 
            this.btnLocalizaTec.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizaTec.Image")));
            this.btnLocalizaTec.Location = new System.Drawing.Point(443, 11);
            this.btnLocalizaTec.Name = "btnLocalizaTec";
            this.btnLocalizaTec.Size = new System.Drawing.Size(43, 43);
            this.btnLocalizaTec.TabIndex = 2;
            this.btnLocalizaTec.UseVisualStyleBackColor = true;
            this.btnLocalizaTec.Click += new System.EventHandler(this.btnLocalizaTec_Click);
            // 
            // lblLocalizaTec
            // 
            this.lblLocalizaTec.AutoSize = true;
            this.lblLocalizaTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizaTec.Location = new System.Drawing.Point(7, 11);
            this.lblLocalizaTec.Name = "lblLocalizaTec";
            this.lblLocalizaTec.Size = new System.Drawing.Size(171, 13);
            this.lblLocalizaTec.TabIndex = 0;
            this.lblLocalizaTec.Text = "Pesquisar Técnica Por Nome";
            // 
            // frmLocalizarTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(520, 371);
            this.Controls.Add(this.panel1);
            this.Name = "frmLocalizarTecnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Técnica";
            this.Load += new System.EventHandler(this.frmLocalizarTecnica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizaTec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLocalizaTec;
        private System.Windows.Forms.TextBox txtLocalizaTec;
        private System.Windows.Forms.Button btnLocalizaTec;
        private System.Windows.Forms.Label lblLocalizaTec;
    }
}