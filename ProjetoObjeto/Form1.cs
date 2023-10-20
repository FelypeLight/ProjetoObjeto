using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoObjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Saida ufa = new Saida();
            if (ufa.ConfirmaOperacao())
            {
                this.Close();
            }

            
             Saida outrasaida = new Saida();
            outrasaida.Legenda = "Presta atenção aqui!";
            outrasaida.ConfirmaOperacao();
            
            //saida.botoes = MessageBoxButtons.YesNoCancel;
            //saida.resposta = MessageBox.Show(saida.Mensagem, saida.Legenda, saida.botoes);
            /*string mensagem = "Você tem certeza?";
            string legenda = "Saída";
             MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult resposta;
            resposta = MessageBox.Show(mensagem, legenda, buttons);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
            */

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Documento aluno = new Documento(textBoxNome.Text, int.Parse(textBoxIdade.Text));
                Documento aluno2 = new Documento("Gilberto", 49);
                //Começo do tratamento dos campos de texto
                Documento documento = new Documento();
                documento.Nome = textBoxNome.Text;
                documento.Idade = int.Parse(textBoxIdade.Text);
                documento.DataNascimento = DateTime.Parse(maskedTextBoxDataNasc.Text);
                //Fim do tratamentos dos campos de texto

                Saida cadastrar = new Saida();
                cadastrar.Legenda = "Confirma operação";
                cadastrar.Mensagem = "Cadastrar o usuário?";
                if (cadastrar.ConfirmaOperacao())
                {
                    MessageBox.Show("Cadastro realizado");
                    textBoxGuardaNomes.Text += $"\n{documento.Nome} {documento.Idade} {documento.DataNascimento.ToShortDateString()}\n\r"; //transformando a string em um template
                    textBoxGuardaNomes.Text += $"\n{aluno.Nome} {aluno.Idade}\n\r";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro encontrado: " + erro);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
