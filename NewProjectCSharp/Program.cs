using System;
using One;
using Classe;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1= (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Laura;
            Pessoas pessoa3 = (Pessoas)4;

            Pessoa person = new Pessoa();

            person.Nome = "Nathalia";
            person.Idade = 29;
            person.Estado = "Sao Paulo";

            var person2 = new Pessoa();

            person2.Nome = "Laura";
            person2.Idade = 18;
            person2.Estado = "Floripa";

            Animal animal = new Animal();

            animal.nome = "Eva";
            animal.nomeDono = "Rafael ";
            animal.Especie = "Coelho";

            var classe = new A();

            Console.WriteLine(pessoa3);
       
        }
    }


} 

