using Exerc_s11_e155.entities.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_s11_e155.entities {
    class Account {
        public int Number { get; set; }
        public String Holder { get; set; }
        public Double Balance { get; private set; }
        public Double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit) {
            Number = number;
            Holder = holder;
            WithDrawLimit = withDrawLimit;
            Deposit(balance);
        }

        public void Deposit(Double amount) {
            Balance += amount;
        }

        public void Withdraw(Double amount) {
            if(Balance <= 0 || Balance < amount || amount > WithDrawLimit) {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
    }
}
