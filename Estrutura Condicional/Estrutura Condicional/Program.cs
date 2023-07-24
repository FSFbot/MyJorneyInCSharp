Console.WriteLine("Resolvendo exercicio 1");

Console.WriteLine("Informe um numero que deseja saber se é negativo ou não");

int number = int.Parse(Console.ReadLine());

if (number < 0) {
    Console.WriteLine("Este numero é negativo");
} else {
    Console.WriteLine("Não Negativo");
}
Console.WriteLine("------------------------------");
Console.WriteLine("Resolvendo exercicio 2 ");
Console.Write("Informe o numero que sera avaliado como par ou impar: ");
int n2 = int.Parse(Console.ReadLine());

if (n2 >= 0 && n2 % 2 == 0) {
    Console.WriteLine("Este numero é par e positivo");
}else if (n2 < 0 && n2 % 2 == 0) {
    Console.WriteLine("Este numero é par e negativo");
}else if (n2 >= 0 && n2 % 2 != 0) {
    Console.WriteLine("Este numero é positovo e impar");
} else {
    Console.WriteLine("Este numero é negativo e impar ");
}
Console.WriteLine("------------------------------");
Console.WriteLine("Resolvendo exercicio 3");
// Neste caso vamos avaliar se um  numero é é realmente um multiplo  de outro;

Console.WriteLine("Escolha os numeros que vão ser analisados");

string[] var1 = Console.ReadLine().Split(' ');
int A = int.Parse(var1[0]);
int B = int.Parse(var1[1]);

if (A % B == 0 || B % A == 0) {
    Console.WriteLine("Os numeros são multip[los entre si");
} else {
    Console.WriteLine("Este numero não são multiplos entre si ");
}

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("Resolvendo o Exerciocio 4");
/*
    Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo podecomeçar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas
 */

Console.WriteLine("Marque que horas o jogo começou e que horas o jogo acabou ");
string[] desafio = Console.ReadLine().Split(' ');
int horaInicial = int.Parse(desafio[0]);
int horaFinal = int.Parse(desafio[1]);
int duracao;
if (horaInicial < horaFinal) {
    duracao = horaFinal - horaInicial;
} else {
    duracao = 24 - horaInicial + horaFinal;
}
Console.WriteLine($"Duraçao do jogo foi de {duracao}");
Console.WriteLine("-------------------------------------------------------");
/*
 Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. Aseguir, calcule e mostre o valor da conta a pagar.
 */

Console.WriteLine("informe o código do item que deseja pedir");
int code  = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade que deseja deste item");
int qtd = int.Parse(Console.ReadLine());
switch (code) {
    case 1: Console.WriteLine($"Foi pedido {qtd} cachorro quente entao deve pagar{(4*qtd):F2}");
        break;
    case 2: Console.WriteLine($"Foi pedido {qtd} X-Salada entao deve pagar{(4.5 * qtd):F2}");
        break;
    case 3: Console.WriteLine($"Foi pedido {qtd} X-Bacon entao deve pagar{(5 * qtd):F2}");
        break;
    case 4: Console.WriteLine($"Foi pedido {qtd} Torrada simples entao deve pagar{(2 * qtd):F2}");
        break;
    case 5: Console.WriteLine($"Foi pedido {qtd} Refrigerante entao deve pagar{(1.5 * qtd):F2}");
        break;
    default: Console.WriteLine("Nao conheco este codigo favor inserir um codigo valido");
        break;
}

Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("Resolvendo o exercicio 7");

Console.WriteLine("Informe um numero => ");
int var7  = int.Parse(Console.ReadLine());

if (var7 < 0 || var7 > 100) {
    Console.WriteLine("Fora do intervalo");
} else if (var7 >= 0 && var7 <= 25) {
    Console.WriteLine("Este numero esta em um intervalo [0;25]");
} else if (var7 > 25 && var7 <= 50) {
    Console.WriteLine(" Este numero estea em um intervalo de [25;50]");
} else if (var7 > 50 && var7 <= 75) {
    Console.WriteLine("Este numero esta em um intevalo de (50;75]");
} else {
    Console.WriteLine("ESte numero esta no intervalo de [75;100]");
}
