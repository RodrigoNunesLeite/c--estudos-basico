using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exerc_s04_e45_classe {
    class Aluno {
        public string nome;
        public double nota1, nota2, nota3;

        public double notaFinal() {
            return nota1 + nota2 + nota3; 
        }

        public void situacao(double nota_final) {

            double pontos_faltantes = 60.00 - nota_final;

            if(nota_final < 60.0) {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTA(RAM) " + pontos_faltantes.ToString("F2",CultureInfo.InvariantCulture) + " PONTOS" );
            } else {
                Console.WriteLine("APROVADO");
            }

        }
    }
}
