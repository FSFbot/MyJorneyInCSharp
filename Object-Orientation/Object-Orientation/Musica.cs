using System.Security.Cryptography.X509Certificates;
// Escrever alguma coisa é o SET ler alguma coisa é o GET
class Musica
{
    public Musica(Bandas artista, string nome)
    {
        Artistas = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Bandas Artistas { get; }// CRTL+R Renomeia os nomes das coisas
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //propriedade fica Pascal Case
    // escrever prop + tab
    public string DescriçãoResumida => 
        $"A musica {Nome} pertence a banda: {Artistas}";
    // Aqui acima vemos uma aplicação de uma função lambda
    public void ExibirFichaTecnica() 
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista {Artistas}");
        Console.WriteLine($"Duraçao: {Duracao}");

       
    }
}
