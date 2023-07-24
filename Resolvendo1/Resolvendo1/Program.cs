Console.WriteLine(@"
██████╗░███████╗░██████╗░█████╗░██╗░░░░░██╗░░░██╗███████╗███╗░░██╗██████╗░░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██║░░░░░██║░░░██║██╔════╝████╗░██║██╔══██╗██╔══██╗
██████╔╝█████╗░░╚█████╗░██║░░██║██║░░░░░╚██╗░██╔╝█████╗░░██╔██╗██║██║░░██║██║░░██║
██╔══██╗██╔══╝░░░╚═══██╗██║░░██║██║░░░░░░╚████╔╝░██╔══╝░░██║╚████║██║░░██║██║░░██║
██║░░██║███████╗██████╔╝╚█████╔╝███████╗░░╚██╔╝░░███████╗██║░╚███║██████╔╝╚█████╔╝
╚═╝░░╚═╝╚══════╝╚═════╝░░╚════╝░╚══════╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░

███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗░█████╗░██╗░█████╗░░██████╗
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║██╔══██╗██║██╔══██╗██╔════╝
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║██║░░╚═╝██║██║░░██║╚█████╗░
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║██║░░██╗██║██║░░██║░╚═══██╗
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║╚█████╔╝██║╚█████╔╝██████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░╚════╝░╚═╝░╚════╝░╚═════╝░");



Console.WriteLine("Entre com primeiro numero");
int n1 =  int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o segundo numero ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Logo o resultado da sua soma sera de {n1 + n2}\n");

Console.WriteLine("=================================================================");

Console.WriteLine("Entre com o valor do raio do circulo!");

int raio = int.Parse(Console.ReadLine());

Console.WriteLine($"Segunda as suas informaçoes seu circulo tem area de {(Math.Pow(raio,2) * Math.PI):F4} unidades de medida");

Console.WriteLine("=================================================================");

Console.WriteLine("Entre com o primeiro valor ");
int A =  int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o Segundo valor ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o Terceiro valor ");
int C = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o Quarto valor ");
int D = int.Parse(Console.ReadLine());

Console.WriteLine($"Podemos notar que a difrença dos produtos apresentado sera de {A*B - C*D}");


Console.WriteLine("=================================================================");

Console.WriteLine("Entre com o numero do funcionario ");
int number =  int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor da hora paga para esse funcionario: ");
double salarioHora =  double.Parse(Console.ReadLine());
Console.WriteLine("Quantas horas este funcionario trabalhou neste mes");
int horas  = int.Parse(Console.ReadLine());

Console.WriteLine($"O funcionario de numero{number}, tem {salarioHora*horas} reais para receber este mes");