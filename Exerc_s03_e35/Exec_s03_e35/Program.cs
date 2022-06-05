using System;

namespace Exec_s03_e35 {
    class Program {
        static void Main(string[] args) {
            /* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os 
             * ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso. */
            /* RESULTADO
            Console.WriteLine("Informe um numero");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Impares:");
            for(int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            } 
            */

            /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X 
             * que serão lidos em seguida. Mostre quantos destes valores X estão dentro do 
             * intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações 
             * conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" 
             * para fora do intervalo). */
            Console.WriteLine("Informe um numero");
            int numero = int.Parse(Console.ReadLine());
            int xIn = 0;
            int xOut = 0;

            for(int i = 1; i <= numero; i++) {
                if (i >= 10 && i <= 20) {
                  xIn++;
                } else {
                   xOut++; 
                }
            }
            Console.WriteLine(xIn + " in");
            Console.WriteLine(xOut + " out");
        }
    }
}
