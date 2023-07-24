using System.Globalization;

Console.WriteLine("Resolução do exercicio 1");
Console.Write("Informe um numero que sera usado: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++) {
    if (i % 2 != 0) {
        Console.WriteLine(i);
    }
}

Console.WriteLine("------------------------------------");
Console.WriteLine("Resolução do exercicio 2");
Console.Write("informe a quatidade de valores que vão ser lidos: ");
int n2 = int.Parse(Console.ReadLine());
int go = 0;
int gout = 0;

for (int i = 0; i < n2; i++) {
    int aux = int.Parse(Console.ReadLine());
    if (aux >= 10 && aux <= 20) {
        go++;
    } else {
        gout++;
    }
}

Console.WriteLine($"Dentro do intervalo podemos encontrar {go} numeros");
Console.WriteLine($"Fora do intervalo podemos encontrar {gout} numeros");

Console.WriteLine("------------------------------------");
Console.WriteLine("Resolução do exercicio 3");

int n3 = int.Parse(Console.ReadLine());


for (int i = 0; i < 0; i++) {

    string[] line = Console.ReadLine().Split(' ');
    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}

Console.WriteLine("------------------------------------");
Console.WriteLine("Resolução do exercicio 4");

Console.WriteLine("Quantos pares de numeros serão avaliados");
int n4 = int.Parse(Console.ReadLine());

for (int i = 0; i < n4; i++) {
    string[] line = Console.ReadLine().Split(' ');
    int x1 = int.Parse(line[0]);
    int y1 = int.Parse(line[1]);

    if (y1 == 0) {
        Console.WriteLine("Esta divisão é impossivel de ocorrer");
    } else {
        double div = (double)x1 / y1;
        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
    }
}
Console.WriteLine("------------------------------------");
Console.WriteLine("Resolução do exercicio 5");
Console.WriteLine("O fatorial de qual numero deseja saber");
int n5 =  int.Parse(Console.ReadLine());
int fat = 1;

for (int i = 1; i <= n5; i++) {
    fat = fat * i;
}
Console.WriteLine($"Fatorial de {n5} é igual a {fat}");

