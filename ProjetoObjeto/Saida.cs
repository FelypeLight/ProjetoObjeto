using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetoObjeto
{
    public class Saida
    {

        #region Atributos/Propriedades/Variáveis
        private string mensagem;
        private string legenda;
        private MessageBoxButtons botoes;
        private DialogResult resposta;
        private string nome;
        #endregion


        #region Método Construtor

        public Saida()
        {
            mensagem = "Você tem certeza?";
            legenda = "Saída do cadastro";
            botoes = MessageBoxButtons.YesNo;
            resposta = DialogResult.No;
            nome = "Jonas";
        }


        #endregion

        #region Métodos da classe

        public string Mensagem { get => mensagem; set => mensagem = value; }
        public string Legenda { get => legenda; set => legenda = value; }
        public MessageBoxButtons Botoes { get => botoes; set => botoes = value; }
        public string Nome { get => nome; set => nome = value; }

        public bool ConfirmaOperacao()
        {
            resposta = MessageBox.Show(mensagem, legenda, botoes);
            if (resposta == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion #region Metdo
    }
}
