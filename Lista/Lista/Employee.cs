using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista {
     class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        // Construtores 
        public Employee (int id,string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }
        // Metodos
        public void IncresesSalary(double percentage) {
            Salary += Salary * percentage / 100;
        }
        // Sobreescrever
        public override string ToString() {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
