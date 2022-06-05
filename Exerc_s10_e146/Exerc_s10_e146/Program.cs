using Exerc_s10_e146.entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exerc_s10_e146 {
    class Program {
        
        static void Main(string[] args) {
            List<Payer> listPayer = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int numberPayers = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberPayers; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char typePayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typePayer == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listPayer.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else if (typePayer == 'c') {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    listPayer.Add(new Company(numberEmployees, name, anualIncome));
                }
               
            }

            double totalTaxes = 0;

            Console.WriteLine("TAXES PAID:");
            foreach(Payer item in listPayer) {
               
                Console.WriteLine(item.ToString());
                totalTaxes += item.CalculateTax();
            }

            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2")} ");

        }
    }
}
