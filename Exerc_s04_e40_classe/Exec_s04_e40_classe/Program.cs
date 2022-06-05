using System;

namespace Exec_s04_e40_classe {
    class Program {
        static void Main(string[] args) {
            /*
             Fazer um programa para ler os dados de duas pessoas, 
            depois mostrar o nome da pessoa mais velha
             */
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade:");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade:");
            pessoa2.idade = int.Parse(Console.ReadLine());

            string nomeMaisVelha = (pessoa1.idade > pessoa2.idade ? pessoa1.nome : pessoa2.nome);

            Console.WriteLine("Pessoa mais velha:" + nomeMaisVelha);
        }
    }
}
