using System;

namespace Exec_s03_e33 {
    class Program {
        static void Main(string[] args) {
            /* Escreva um programa que repita a leitura de uma senha até que ela seja válida. 
             * Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". 
             * Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" 
             * e o algoritmo encerrado. Considere que a senha correta é o valor 2002. */

            Console.WriteLine("Informe a senha:");
            string senha = Console.ReadLine();

            while (senha != "2002") {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Informe a senha novamente:");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}
