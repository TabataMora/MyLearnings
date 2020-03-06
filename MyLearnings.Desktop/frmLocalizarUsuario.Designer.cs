namespace MyLearnings.Desktop
{
    partial class frmLocalizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizarUsuario));
            this.lblLocalizaUsu = new System.Windows.Forms.Label();
            this.txtLocalizaUsu = new System.Windows.Forms.TextBox();
            this.btnLocalizaUsu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLocalizaUsu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizaUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocalizaUsu
            // 
            this.lblLocalizaUsu.AutoSize = true;
            this.lblLocalizaUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizaUsu.Location = new System.Drawing.Point(6, 5);
            this.lblLocalizaUsu.Name = "lblLocalizaUsu";
            this.lblLocalizaUsu.Size = new System.Drawing.Size(168, 13);
            this.lblLocalizaUsu.TabIndex = 0;
            this.lblLocalizaUsu.Text = "Pesquisar Usuário Por Nome";
            // 
            // txtLocalizaUsu
            // 
            this.txtLocalizaUsu.Location = new System.Drawing.Point(9, 21);
            this.txtLocalizaUsu.Name = "txtLocalizaUsu";
            this.txtLocalizaUsu.Size = new System.Drawing.Size(552, 20);
            this.txtLocalizaUsu.TabIndex = 1;
            // 
            // btnLocalizaUsu
            // 
            this.btnLocalizaUsu.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizaUsu.Image")));
            this.btnLocalizaUsu.Location = new System.Drawing.Point(567, 9);
            this.btnLocalizaUsu.Name = "btnLocalizaUsu";
            this.btnLocalizaUsu.Size = new System.Drawing.Size(43, 43);
            this.btnLocalizaUsu.TabIndex = 2;
            this.btnLocalizaUsu.UseVisualStyleBackColor = true;
            this.btnLocalizaUsu.Click += new System.EventHandler(this.btnLocalizaUsu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLocalizaUsu);
            this.panel1.Controls.Add(this.txtLocalizaUsu);
            this.panel1.Controls.Add(this.btnLocalizaUsu);
            this.panel1.Controls.Add(this.lblLocalizaUsu);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 344);
            this.panel1.TabIndex = 3;
            // 
            // dgvLocalizaUsu
            // 
            this.dgvLocalizaUsu.AllowUserToAddRows = false;
            this.dgvLocalizaUsu.AllowUserToDeleteRows = false;
            this.dgvLocalizaUsu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalizaUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalizaUsu.Location = new System.Drawing.Point(9, 58);
            this.dgvLocalizaUsu.Name = "dgvLocalizaUsu";
            this.dgvLocalizaUsu.ReadOnly = true;
            this.dgvLocalizaUsu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalizaUsu.Size = new System.Drawing.Size(601, 279);
            this.dgvLocalizaUsu.TabIndex = 3;
            this.dgvLocalizaUsu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalizaUsu_CellContentClick);
            // 
            // frmLocalizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(626, 354);
            this.Controls.Add(this.panel1);
            this.Name = "frmLocalizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Usuário";
            this.Load += new System.EventHandler(this.frmLocalizarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizaUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLocalizaUsu;
        private System.Windows.Forms.TextBox txtLocalizaUsu;
        private System.Windows.Forms.Button btnLocalizaUsu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLocalizaUsu;
    }
}