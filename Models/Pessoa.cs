using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa() {}

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;

        private string _sobrenome;

        public string Nome 
        { 
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O campo Nome não pode ficar vazio");
                }

                _nome = value;
            } 
        }

        public string Sobrenome
        {
             get => _sobrenome;
             
             set
             {
                if (value == "")
                {
                    throw new ArgumentException("O campo Sobrenome não pode ficar vazio");
                }

                _sobrenome = value;
             }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}