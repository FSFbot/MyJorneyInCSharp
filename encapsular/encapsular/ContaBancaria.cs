using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsular {
    class ContaBancaria {
        public int Numero { get; private set; }
        public  string Titular { get; set; }
        public double Saldo { get;private set; } // Nesta linha estamos falando que esta linha podemos ver o saldo, mas não podemos alterar ele

        // Abaixo podemos ver os construtores, eles informam o que podemos colocar como parametros, neste caso temos 3 e 2 parametros necessario
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double saldo) :this(numero,titular){
            Saldo = saldo;
        }
        // Etapa de criação dos metodos da nossa conta bancaria
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {

            Saldo -= quantia + 5.0;
        }

        // Agora vamos a etapa, de sobreescrever ja que vamos ter que colocar novas informaçoes para que o sistema possa ler elas
        public override string ToString() {
            return $"Conta: {Numero}, Titular {Titular}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}
