using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorOOP
{
    class Pessoa
    {
        // Construtor
        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
        public Pessoa(int idade)
        {
            Console.WriteLine("idade " + idade);
        }

        public Pessoa(double cpf)
        {
            Console.WriteLine("cpf " + cpf);
        }

    }
}
