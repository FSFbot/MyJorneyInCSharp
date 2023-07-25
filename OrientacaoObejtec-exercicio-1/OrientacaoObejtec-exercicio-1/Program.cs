using OrientacaoObejtec_exercicio_1;
using System.Globalization;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Idade: ");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da primeira pessoa");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.Write("Idade: ");
p2.idade = int.Parse(Console.ReadLine());

if(p1.idade > p2.idade) {
    Console.WriteLine($"Pessoa mais velha sera: {p1.Nome}");
} else {
    Console.WriteLine($"Pessoa mais velha sera: {p2.Nome}");
}
Console.WriteLine("******************************************************************");
Console.WriteLine("Resolvendo o exercicio numero 2");

Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();

Console.WriteLine("Dados do primeiro funcionario: ");
Console.Write("Nome: ");
f1.Nome = Console.ReadLine();
Console.WriteLine("Salario: ");
f1.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Dados do primeiro funcionario: ");
Console.Write("Nome: ");
f2.Nome = Console.ReadLine();
Console.WriteLine("Salario: ");
f2.Salario = double.Parse(Console.ReadLine());

double media = (f1.Salario + f2.Salario) / 2.0;

Console.WriteLine("Salario médio = "+ media.ToString("F2",CultureInfo.InvariantCulture));