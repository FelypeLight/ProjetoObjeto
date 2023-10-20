using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoObjeto
{
    public class Documento
    {
        #region Atributos
        private string nome;
        private int idade;
        private DateTime dataNascimento;
        #endregion

        #region Método Construtor
        public Documento()
        {
            //nome = "";
            //idade = 0;
            //dataNascimento = DateTime.Today;
        }

        public Documento(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            
        }
        #endregion

        #region Métodos
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }


        #endregion
    }
}
