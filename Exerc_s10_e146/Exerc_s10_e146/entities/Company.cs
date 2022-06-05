using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_s10_e146.entities {
    class Company : Payer {

        public int NumberEmployees;

        public Company(int numberEmployees, String name, Double annualIncome) : base(name, annualIncome) {
            NumberEmployees = numberEmployees;
        }
        public override double CalculateTax() {
            double CalculatedValue;
            if (NumberEmployees > 10) {
                CalculatedValue = AnnualIncome * 0.14;
            } else {
                CalculatedValue = AnnualIncome * 0.16;
            }
            return CalculatedValue;
        }

        public override string ToString() {
            return Name + ": $ " + CalculateTax().ToString("F2");
        }
    }
}
