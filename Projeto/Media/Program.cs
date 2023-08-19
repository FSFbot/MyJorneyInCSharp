using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program{
    public static void Main(string[] args){
        System.Console.Write("Ola informe quandtas notas vão ser lidas ! : " );
        int number = int.Parse(Console.ReadLine());
        Console.Write("Qual o nome do aluno: ");
        string nome = Console.ReadLine();
        double sum = 0;
        for(int i = 0; i < number; i++){
            System.Console.WriteLine($"Informe a nota {i+1}");
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sum = nota + sum;
        }
        System.Console.Write($"Então podemos ver que o {nome} teve media igual a {sum/number} ");
    }
}
