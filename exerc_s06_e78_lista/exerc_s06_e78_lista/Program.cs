using System;
using System.Collections.Generic;
using System.Globalization;

namespace exerc_s06_e78_lista {
    class Program {
        static int id_employee;
        static double increase_percentage;
        static int number_employees;
        static List<Employee> lst_empl = new List<Employee>();    
        
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            number_employees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number_employees; i++) {
                
                double salary;

                Console.WriteLine($"Employee #{i}");
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                salary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lst_empl.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            id_employee = int.Parse(Console.ReadLine());

            Employee emp = lst_empl.Find(x => x.Id == id_employee);
            
            if(emp != null) {
                Console.Write("Enter the percentage : ");
                increase_percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.increaseSalary(increase_percentage);

            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in lst_empl) {
                Console.WriteLine(obj);
            }
        }
    }
}
