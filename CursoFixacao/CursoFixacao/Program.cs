using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritorio";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine($"{produto1}, cujo o preço é $ {preco1:F2}");
Console.WriteLine($"{produto2}, cujo o preço é $ {preco2:F2}");
Console.WriteLine(" ");
Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero: {genero}");

Console.WriteLine($"{medida:F3}");
Console.WriteLine(medida.ToString(CultureInfo.InvariantCulture));
Console.WriteLine($"{medida:F8}");

Console.WriteLine("Entre com o Seu nome");
string _Nome = Console.ReadLine();
Console.WriteLine("Quiantos quartos tem a sua casa");
string quarto = Console.ReadLine();
Console.WriteLine("Entre com o preço do produto");
float _preco = float.Parse(Console.ReadLine());

string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
int _idade = int.Parse(vet[1]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


Console.WriteLine(_Nome);
Console.WriteLine(quarto);
Console.WriteLine(_preco);
