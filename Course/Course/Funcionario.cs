using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
     class Funcionario {
        public string Nome;
        public double Salario;
        public double imposto;

        public double SalarioLiquido() {
            return Salario - imposto;
        }

        public void AumentarSalario(double porcentagem) {
            Salario = Salario + (Salario * porcentagem / 100);
        }
        public override string ToString() {
            return Nome
            +", R$ "
            + SalarioLiquido().ToString("F2");
        }
    }
}
