using System;
using System.Globalization;

namespace Exec_s03_e24 {
    class Program {
        static void Main(string[] args) {
            /*
             Faça um programa para ler dois valores inteiros, e depois mostrar na tela a 
             soma desses números com uma mensagem explicativa, conforme exemplos.
             */
            /* RESULTADO 
            Console.WriteLine("Informe o 1º numero para a soma:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2º numero para a soma:");
            int numero2 = int.Parse(Console.ReadLine());
            int soma = numero1 + numero2;
            Console.WriteLine("SOMA = " + soma);
            */

            /*
                Faça um programa para ler o valor do raio de um círculo, e 
                depois mostrar o valor da área deste círculo com quatro
                casas decimais conforme exemplos
             */
            /* RESULTADO
            Console.WriteLine("Informe o valor do raio de um círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
            */

            /*
              Fazer um programa para ler quatro valores inteiros A, B, C e D. 
              A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D 
              segundo a fórmula: DIFERENCA = (A * B - C * D).
            */
            /* RESULTADO
            string[] vectInteiros = Console.ReadLine().Split(' ');

            int numA = int.Parse(vectInteiros[0]);
            int numB = int.Parse(vectInteiros[1]);
            int numC = int.Parse(vectInteiros[2]);
            int numD = int.Parse(vectInteiros[3]);

            Console.WriteLine("Diferenca = " + ((numA * numB) - (numC * numD)));
            */

            /*
                Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
                o valor que recebe por hora e calcula o salário desse funcionário. 
                A seguir, mostre o número e o salário do funcionário, com duas casas decimais. 
            */
            /* RESULTADO
            Console.WriteLine("Informe o número do funcionário:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas:");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor que recebe por hora:");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Número = " + numero);
            Console.WriteLine("Salário = U$ " + (horasTrabalhadas * valorPorHora).ToString("F2", CultureInfo.InvariantCulture));
            */


            /*
             Fazer um programa para ler o código de uma peça 1, o número de peças 1, 
             o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o 
             valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
             */
            Console.WriteLine("Informe respectivamente código da peça 1, número de peças e o valor unitário:");
            string[] vectPeca1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Informe respectivamente código da peça 2, número de peças e o valor unitário:");
            string[] vectPeca2 = Console.ReadLine().Split(' ');

            double valorPagoPeca1 = int.Parse(vectPeca1[1]) * double.Parse(vectPeca1[2], CultureInfo.InvariantCulture);
            double valorPagoPeca2 = int.Parse(vectPeca2[1]) * double.Parse(vectPeca2[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a pagar: R$ " + (valorPagoPeca1 + valorPagoPeca2).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
