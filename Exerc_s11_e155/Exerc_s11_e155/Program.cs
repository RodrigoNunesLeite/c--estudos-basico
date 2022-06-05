using System;
using System.Globalization;
using Exerc_s11_e155.entities;
using Exerc_s11_e155.entities.exceptions;

namespace Exerc_s11_e155 {
    class Program {
        /*
         Fazer um programa para ler os dados de uma conta bancária e depois realizar um
        saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
        ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
        saque da conta. 
         */
        static void Main(string[] args) {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            String holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, initialBalance, withdrawLimit);
            
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            try { 
                double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amountWithdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture)); 
            } catch(DomainException e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}

