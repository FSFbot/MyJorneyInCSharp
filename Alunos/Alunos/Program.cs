using Alunos.Entities;
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de alunos");
            int n = int.Parse(Console.ReadLine());

            List<Aluno> alunos = new List<Aluno>();
            
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o nome do aluno {i + 1}:");
            string nome = Console.ReadLine();

            Console.WriteLine($"Quantas notas o lunos {nome} possui?");
            int numNotas = int.Parse(Console.ReadLine());

            List<double> notas = new List<double>();
            for(int j = 0; j  < numNotas; j++)
            {
                Console.WriteLine($"Digite a nota {j + 1} do aluno {nome}: ");
                double nota = double .Parse(Console.ReadLine());    
                notas.Add(nota);
            }
            alunos.Add(new Aluno { Nome = nome, Notas = notas });
        }
        Console.WriteLine("\nResultados: ");
        foreach(var aluno in alunos)
        {
            Console.WriteLine($"O aluno {aluno.Nome} tem uma média de {aluno.Media():F2}.");
        }
    }
    }

