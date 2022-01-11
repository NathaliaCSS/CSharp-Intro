using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IAnimal
    {
        void Nome(String nome);
        void Dono(String nomeDono);
        void Especie(string Especie);
    }
    class Animal : IAnimal
    {
        public  string nome { get; set; }
        public string nomeDono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.nome = nome;
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.nome = nomeDono;
        }

        void IAnimal.Especie(string especie)
        {
            this.nome = especie;
        }
    }
}
