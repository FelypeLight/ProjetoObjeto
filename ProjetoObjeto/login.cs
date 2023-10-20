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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void BotaoClicarLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PreencherNomeLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void PreencherSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotaoClicarLogin_Click_1(object sender, EventArgs e)
        {
            Saida mensagem = new Saida();
            mensagem.Botoes = MessageBoxButtons.OK;
            mensagem.Nome = "Felype";


            Usuario usuario = new Usuario();
            Saida menagem = new Saida();
            mensagem.Botoes = MessageBoxButtons.OK;

            try
            {
                string nome = PreencherNomeLogin.Text;
                string senha = PreencherSenhaLogin.Text;
                string privilegio = "comum";
                if (usuario.verificaLogin(nome, senha, privilegio))
                {
                    mensagem.Legenda = "Autorização";
                    mensagem.Mensagem = "Acesso autorizado";
                    mensagem.ConfirmaOperacao();
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();


                }
                else
                {
                    mensagem.Legenda = "Erro";
                    mensagem.Mensagem = "Acesso não autorizado";
                    mensagem.ConfirmaOperacao();
                }



            }
            catch (Exception erro)
            {

                mensagem.Mensagem = "Erro: " + erro;

            }


        }
    }
}
