using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoObjeto
{
    class Usuario
    {
        private string nome;
        private string senha;
        private string privilegio;

            public Usuario()
            {
                nome = "Felype";
                senha = "1234";
                privilegio = "comum";
            }

        public static object System { get; internal set; }
        public string Nome { get => nome; set => nome = value; }
            public string Senha { get => senha; set => senha = value; }
            public string Privilegio { get => privilegio; set => privilegio = value; }

            public Boolean verificaLogin(string nome, string senha, string privilegio)
            {
                if (this.nome == nome && this.senha == senha && this.privilegio == privilegio)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }




