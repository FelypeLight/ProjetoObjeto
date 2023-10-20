namespace ProjetoObjeto
{
    partial class Menu
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.linkLabelCadastro = new System.Windows.Forms.LinkLabel();
            this.menuStripMenuSuspenso = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelEncerrar = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripMenuSuspenso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(122, 50);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(77, 13);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Menu Principal";
            // 
            // linkLabelCadastro
            // 
            this.linkLabelCadastro.AutoSize = true;
            this.linkLabelCadastro.Location = new System.Drawing.Point(82, 111);
            this.linkLabelCadastro.Name = "linkLabelCadastro";
            this.linkLabelCadastro.Size = new System.Drawing.Size(49, 13);
            this.linkLabelCadastro.TabIndex = 1;
            this.linkLabelCadastro.TabStop = true;
            this.linkLabelCadastro.Text = "Cadastro";
            this.linkLabelCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCadastro_LinkClicked);
            // 
            // menuStripMenuSuspenso
            // 
            this.menuStripMenuSuspenso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStripMenuSuspenso.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenuSuspenso.Name = "menuStripMenuSuspenso";
            this.menuStripMenuSuspenso.Size = new System.Drawing.Size(800, 24);
            this.menuStripMenuSuspenso.TabIndex = 2;
            this.menuStripMenuSuspenso.Text = "Menu Suspenso";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // linkLabelEncerrar
            // 
            this.linkLabelEncerrar.AutoSize = true;
            this.linkLabelEncerrar.Location = new System.Drawing.Point(181, 111);
            this.linkLabelEncerrar.Name = "linkLabelEncerrar";
            this.linkLabelEncerrar.Size = new System.Drawing.Size(47, 13);
            this.linkLabelEncerrar.TabIndex = 3;
            this.linkLabelEncerrar.TabStop = true;
            this.linkLabelEncerrar.Text = "Encerrar";
            this.linkLabelEncerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEncerrar_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoObjeto.Properties.Resources._266fc5df40ce98ad0d6823016d809b017936115br1_960_540v2_hq;
            this.pictureBox1.Location = new System.Drawing.Point(-56, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 498);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelEncerrar);
            this.Controls.Add(this.linkLabelCadastro);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.menuStripMenuSuspenso);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStripMenuSuspenso;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStripMenuSuspenso.ResumeLayout(false);
            this.menuStripMenuSuspenso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.LinkLabel linkLabelCadastro;
        private System.Windows.Forms.MenuStrip menuStripMenuSuspenso;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabelEncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}