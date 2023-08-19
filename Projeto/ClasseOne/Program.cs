using ClasseOne.Entities;

class Program
{
   public static void Main(string[] args)
    {
        var conta = new ContaBancaria("João", "12345");
        conta.Depositar(500.0M);
        conta.MostrarSaldo();
        conta.Sacar(200.0M);
        conta.MostrarSaldo();
        conta.Sacar(500.0M);  // Deve mostrar uma mensagem de saldo insuficiente.

    }
}