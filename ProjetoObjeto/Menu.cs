using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoObjeto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void linkLabelCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog(); //Ele bloqueia a tela anterior
            this.Show();
            //form1.Show(); //Ele não bloqueia a tela anterior
        }

        private void linkLabelEncerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Saida sair = new Saida();
            if (sair.ConfirmaOperacao())
            {
                //this.Close();
                Application.Exit();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }
    }
}
