using System;

namespace ProjetoObjeto
{
    partial class login
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
            this.label2 = new System.Windows.Forms.Label();
            this.PreencherNomeLogin = new System.Windows.Forms.TextBox();
            this.PreencherSenhaLogin = new System.Windows.Forms.TextBox();
            this.BotaoClicarLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // PreencherNomeLogin
            // 
            this.PreencherNomeLogin.Location = new System.Drawing.Point(413, 126);
            this.PreencherNomeLogin.Name = "PreencherNomeLogin";
            this.PreencherNomeLogin.Size = new System.Drawing.Size(100, 20);
            this.PreencherNomeLogin.TabIndex = 2;
            this.PreencherNomeLogin.TextChanged += new System.EventHandler(this.PreencherNomeLogin_TextChanged);
            // 
            // PreencherSenhaLogin
            // 
            this.PreencherSenhaLogin.Location = new System.Drawing.Point(413, 182);
            this.PreencherSenhaLogin.Name = "PreencherSenhaLogin";
            this.PreencherSenhaLogin.Size = new System.Drawing.Size(100, 20);
            this.PreencherSenhaLogin.TabIndex = 3;
            this.PreencherSenhaLogin.TextChanged += new System.EventHandler(this.PreencherSenhaLogin_TextChanged);
            // 
            // BotaoClicarLogin
            // 
            this.BotaoClicarLogin.Location = new System.Drawing.Point(385, 259);
            this.BotaoClicarLogin.Name = "BotaoClicarLogin";
            this.BotaoClicarLogin.Size = new System.Drawing.Size(75, 23);
            this.BotaoClicarLogin.TabIndex = 4;
            this.BotaoClicarLogin.Text = "Login";
            this.BotaoClicarLogin.UseVisualStyleBackColor = true;
            this.BotaoClicarLogin.Click += new System.EventHandler(this.BotaoClicarLogin_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoObjeto.Properties.Resources.cps_logo_cortado;
            this.pictureBox1.Location = new System.Drawing.Point(66, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoObjeto.Properties.Resources.c463b0484625cf33bf558a0046b1e0d9a8c887843367c296169d3ba777c62a9a;
            this.pictureBox2.Location = new System.Drawing.Point(-115, -82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1026, 713);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoClicarLogin);
            this.Controls.Add(this.PreencherSenhaLogin);
            this.Controls.Add(this.PreencherNomeLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreencherNomeLogin;
        private System.Windows.Forms.TextBox PreencherSenhaLogin;
        private System.Windows.Forms.Button BotaoClicarLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}