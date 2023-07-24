class Album 
{
    private  List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;  }
    public int DuracaoTotalDoAlbum => musicas.Sum(musica => musica.Duracao);

    public int DuracaoTotal { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMuscasDoALbum()
    {
        Console.WriteLine($"Lista de músicas do album{Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musicas {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este album inteiro vc precisa de {DuracaoTotal} ");
    }
}