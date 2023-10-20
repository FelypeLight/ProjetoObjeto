namespace ProjetoObjeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelDtNasc = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.maskedTextBoxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxGuardaNomes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripCadastro = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(617, 365);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(117, 40);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "Clique para sair";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(193, 99);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(282, 20);
            this.textBoxNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxNome, "Insira o seu primeiro nome");
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(193, 155);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(47, 20);
            this.textBoxIdade.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxIdade, "Insira a idade. Ex.: 18");
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(152, 102);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(153, 158);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(34, 13);
            this.labelIdade.TabIndex = 5;
            this.labelIdade.Text = "Idade";
            // 
            // labelDtNasc
            // 
            this.labelDtNasc.AutoSize = true;
            this.labelDtNasc.Location = new System.Drawing.Point(265, 158);
            this.labelDtNasc.Name = "labelDtNasc";
            this.labelDtNasc.Size = new System.Drawing.Size(104, 13);
            this.labelDtNasc.TabIndex = 6;
            this.labelDtNasc.Text = "Data de Nascimento";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(253, 213);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 7;
            this.buttonEnviar.Text = "Cadastrar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // maskedTextBoxDataNasc
            // 
            this.maskedTextBoxDataNasc.Location = new System.Drawing.Point(375, 155);
            this.maskedTextBoxDataNasc.Mask = "00/00/0000";
            this.maskedTextBoxDataNasc.Name = "maskedTextBoxDataNasc";
            this.maskedTextBoxDataNasc.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataNasc.TabIndex = 8;
            this.maskedTextBoxDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Dica";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // textBoxGuardaNomes
            // 
            this.textBoxGuardaNomes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGuardaNomes.Location = new System.Drawing.Point(567, 107);
            this.textBoxGuardaNomes.Multiline = true;
            this.textBoxGuardaNomes.Name = "textBoxGuardaNomes";
            this.textBoxGuardaNomes.Size = new System.Drawing.Size(201, 129);
            this.textBoxGuardaNomes.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clientes cadastrados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoObjeto.Properties.Resources.cropped_BRASÃO_ESCOLA_OFICIAL_2_1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoObjeto.Properties.Resources.cps_logo_cortado;
            this.pictureBox1.Location = new System.Drawing.Point(517, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // menuStripCadastro
            // 
            this.menuStripCadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStripCadastro.Location = new System.Drawing.Point(0, 0);
            this.menuStripCadastro.Name = "menuStripCadastro";
            this.menuStripCadastro.Size = new System.Drawing.Size(800, 24);
            this.menuStripCadastro.TabIndex = 13;
            this.menuStripCadastro.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBoxDataNasc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGuardaNomes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.labelDtNasc);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.menuStripCadastro);
            this.MainMenuStrip = this.menuStripCadastro;
            this.Name = "Form1";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripCadastro.ResumeLayout(false);
            this.menuStripCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelDtNasc;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataNasc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxGuardaNomes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}

