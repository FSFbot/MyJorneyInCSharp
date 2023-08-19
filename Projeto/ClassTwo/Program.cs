using ClassTwo.Entities;

class Program
{
    public static void Main(string[] args)
    {
        var livro = new Livro(
            "O Nome do Vento",
            "Patrick Rothfuss",
            "1234567890123",
            662,
            "A história de Kvothe, um arcanista talentoso que cresce para ser uma lenda viva."
        );

        livro.Ler();
        livro.Resumir();

    }
}