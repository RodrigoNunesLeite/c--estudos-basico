using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_s10_e146.entities {
    class Individual : Payer {
        public double HealthExpenses { get; set; }

        public Individual(Double healthExpenses, String name, Double annualIncome) : base(name, annualIncome) {
            HealthExpenses = healthExpenses;
        }

        public override double CalculateTax() {
            double CalculatedValue;

            if (AnnualIncome < 20000.00) {
                CalculatedValue = AnnualIncome * 0.15;
            } else {
                CalculatedValue = AnnualIncome * 0.25;
            }

            if (HealthExpenses > 0) {
                CalculatedValue -= (HealthExpenses * 0.5);
            }

            return CalculatedValue;
        }

        public override string ToString() {
            return Name + ": $ " + CalculateTax().ToString("F2"); 
        }
    }
}
