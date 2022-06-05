using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_s04_e48_classe_estatico {
    class ConversorDeMoeda {
        private static double iof = 0.06;
        public static double converteMoeda(double cotacao, double valor) {
            double valorPago = cotacao * valor;
            valorPago += valorPago * iof;

            return valorPago;
        }
    }
}
