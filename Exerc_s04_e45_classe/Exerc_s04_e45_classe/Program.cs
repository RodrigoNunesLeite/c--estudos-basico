using System;
using System.Globalization;

namespace Exerc_s04_e45_classe {
    class Program {
        static void Main(string[] args) {
            /* Fazer um programa para ler o nome de um aluno e as três notas 
             * que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e 
             * terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. 
             * Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos 
             * pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). 
             * Você deve criar uma classe Aluno para resolver este problema.*/
            Aluno aluno1 = new Aluno();
            Console.WriteLine("Nome do aluno:");
            aluno1.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            
            aluno1.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno1.notaFinal();

            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));
            aluno1.situacao(notaFinal);

        }
    }
}
