using System;

namespace Exec_s03_e29 {
    class Program {
        static void Main(string[] args) {
            /* Exercicios Estrutura condicional */
            /*
            Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. 
            */
            /* RESULTADO
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(numero < 0 ? "Negativo" : "Nao Negativo");
            */
            /*
            Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar     
            */
            /* RESULTADO
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(numero % 2 == 0 ? "Par" : "Impar"); 
            */
            /*
                Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem 
                "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são 
                múltiplos entre si. Atenção: os números devem poder ser digitados em
                ordem crescente ou decrescente. 
            */
            /* RESULTADO
            int numeroA = int.Parse(Console.ReadLine());
            int numeroB = int.Parse(Console.ReadLine());
            if (numeroA % numeroB == 0 || numeroB % numeroA == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            } */

            /*
             Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
             sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração 
             mínima de 1 hora e máxima de 24 horas.
             */
            int horaInicial = int.Parse(Console.ReadLine());
            int horaFinal = int.Parse(Console.ReadLine());
            int totalHoras = 0;
            if (horaInicial < horaFinal) {
                totalHoras = horaFinal - horaInicial;
            } else {
                totalHoras = (24 - horaInicial) + horaFinal;
            }
            Console.WriteLine($"O jogo durou {totalHoras} hora(s)");


        }
    }
}
