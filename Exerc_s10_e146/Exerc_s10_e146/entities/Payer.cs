using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_s10_e146.entities {
    abstract class Payer {
        public String Name { get; set; }
        public Double AnnualIncome { get; set; }

        public Payer(String name, Double annualIncome) {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double CalculateTax();

        public override abstract string ToString();
        
    }
}
