

namespace ClasseOne.Entities
{
    public class ContaBancaria
    {
        // Atributos
        private string _titular;
        private string _numeroDaConta;
        private decimal _saldo;

        // Propriedades
        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public string NumeroDaConta
        {
            get { return _numeroDaConta; }
            set { _numeroDaConta = value; }
        }

        public decimal Saldo
        {
            get { return _saldo; }
            private set { _saldo = value; } // O saldo só pode ser modificado pelos métodos de depósito e saque.
        }

        // Construtor
        public ContaBancaria(string titular, string numeroDaConta)
        {
            _titular = titular;
            _numeroDaConta = numeroDaConta;
            _saldo = 0.0M; // Supondo que ao criar uma conta, o saldo é 0.
        }

        // Métodos
        public void Depositar(decimal valor)
        {
            if (valor > 0) // Verifica se o valor do depósito é positivo
            {
                _saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= _saldo && valor > 0) // Verifica se há saldo suficiente e se o valor de saque é positivo
            {
                _saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo atual: {_saldo:C}");
        }
    }

}
