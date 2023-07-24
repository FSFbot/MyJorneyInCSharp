class Bandas
{
    private List<Album> albuns  = new List<Album>();

    public Bandas(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; } 

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da Banda {Nome}");

        foreach(Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}