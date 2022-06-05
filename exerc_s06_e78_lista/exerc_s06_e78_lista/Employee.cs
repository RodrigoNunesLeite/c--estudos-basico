using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exerc_s06_e78_lista {
    class Employee {

        private int _id;
        private string _name;

        private double _salary;

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            setSalary(salary);

        }

        public int Id {
            get { return _id; }
            set {
                if (value != null && value > 1) {
                    _id = value;
                }
            }
        }

        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }

        public double getSalary() {
            return _salary;
        }

        public void setSalary(double salary) {
            _salary = salary;
        }

        public void increaseSalary(double percentage) {
            double valuePercentage = _salary * percentage;
            _salary += valuePercentage;
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + getSalary().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
