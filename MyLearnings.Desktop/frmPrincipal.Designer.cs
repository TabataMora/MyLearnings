namespace MyLearnings.Desktop
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cicloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cicloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resumoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.históricoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.técnicaToolStripMenuItem,
            this.cicloToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.resumoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // técnicaToolStripMenuItem
            // 
            this.técnicaToolStripMenuItem.Name = "técnicaToolStripMenuItem";
            this.técnicaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.técnicaToolStripMenuItem.Text = "Técnica";
            this.técnicaToolStripMenuItem.Click += new System.EventHandler(this.técnicaToolStripMenuItem_Click);
            // 
            // cicloToolStripMenuItem
            // 
            this.cicloToolStripMenuItem.Name = "cicloToolStripMenuItem";
            this.cicloToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cicloToolStripMenuItem.Text = "Ciclo";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // resumoToolStripMenuItem
            // 
            this.resumoToolStripMenuItem.Name = "resumoToolStripMenuItem";
            this.resumoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.resumoToolStripMenuItem.Text = "Resumo";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // históricoToolStripMenuItem1
            // 
            this.históricoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cicloToolStripMenuItem1,
            this.resumoToolStripMenuItem1});
            this.históricoToolStripMenuItem1.Name = "históricoToolStripMenuItem1";
            this.históricoToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.históricoToolStripMenuItem1.Text = "Histórico";
            // 
            // cicloToolStripMenuItem1
            // 
            this.cicloToolStripMenuItem1.Name = "cicloToolStripMenuItem1";
            this.cicloToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cicloToolStripMenuItem1.Text = "Ciclo";
            this.cicloToolStripMenuItem1.Click += new System.EventHandler(this.cicloToolStripMenuItem1_Click);
            // 
            // resumoToolStripMenuItem1
            // 
            this.resumoToolStripMenuItem1.Name = "resumoToolStripMenuItem1";
            this.resumoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.resumoToolStripMenuItem1.Text = "Resumo";
            this.resumoToolStripMenuItem1.Click += new System.EventHandler(this.resumoToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem técnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cicloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cicloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resumoToolStripMenuItem1;
    }
}