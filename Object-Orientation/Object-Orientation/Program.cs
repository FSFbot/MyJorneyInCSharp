Bandas metalica = new Bandas("metalica");

Album albumDoMetelica = new Album("The Black Album");

Musica musica1 = new Musica(metalica, "Enter the Sandman")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(metalica, "Sad but True") 
{
    Duracao = 342, Disponivel = true,
};

albumDoMetelica.ExibirMuscasDoALbum();


metalica.AdicionarAlbum(albumDoMetelica);
metalica.ExibirDiscografia();

Episodio ep1 = new(1, "Tecnica de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
Console.WriteLine(ep1);

Episodio ep2 = new(2, "A magica do Back end", 65);
ep1.AdicionarConvidados("Felipe Freitas");
ep1.AdicionarConvidados("Bia CodeTech");
Console.WriteLine(ep2);

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();