using Course;
using System.Drawing;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Ola usuario seja bem vindo ao programa");

        Retangulo ret = new Retangulo();

        Console.WriteLine("Entre com a largura e altura de um retangulo");
        ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("**********************************");
        Console.WriteLine("Resolução do exercicio 2");
        Funcionario func = new Funcionario();
        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();
        Console.WriteLine("Salario Bruto: ");
        func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        func.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine($"Funcionario:{func} ");
        Console.WriteLine();
        Console.WriteLine("Deseja aumentar o salario em qual porcentagem ?");
        double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        func.AumentarSalario(porcent);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: "+ func);

        Console.WriteLine("************************************");
        Console.WriteLine("Exercicio 3");
        Aluno aluno = new Aluno();

        Console.WriteLine("Nome do Aluno: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite as tres notas do alunos: ");
        aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Nota Final =" +aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

        if (aluno.Aprovado()) {
            Console.WriteLine("APROVADO");
        } else {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM"+ aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
        }
    }    
}


