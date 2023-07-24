// Scream Sound um aplicativo de musicas 

string mensagemDeBoasVindas = "Boas vindas ao Scream Sound"; // Variaveis são com camelcase
void ExibirLogo() // Funções são com camelCase
{
    // Verbatin Literal.
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗░█████╗░███╗░░░███╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔══██╗████╗░████║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░███████║██╔████╔██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══██║██║╚██╔╝██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░░██║██║░╚═╝░██║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
   
}

//List<string> ListasDasBandas = new List<string> { "Bring me the horizon", "Metalica", "Megadeath"};
Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("Link park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Beatles", new List<int>());
void ExibirOpcoes()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar a sua banda");
    Console.WriteLine("Digite 2 para mostrar a sua banda");
    Console.WriteLine("Digite 3 para avaliar a sua banda");
    Console.WriteLine("Digite 4 para ver a média das bandas a sua banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            MediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
    }

}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulodaOpcao("Resgistrar bandas");
    Console.WriteLine("Digite o  nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!; // esta exclamação informa que não vamos aceitar valores nulos 
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda{nomeDaBanda} foi registrada com sucesso "); // aqui foi usado conceito de intepolação de strings
    Thread.Sleep(2000);
    Console.Clear() ;
    ExibirOpcoes();
}
void MostrarBandas()
{
    Console.Clear();
    ExibirTitulodaOpcao("Mostrar todas as bandas registradas");
   /* for(int i = 0; i< ListasDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda {ListasDasBandas[i]}\n");
    }*/
   foreach(String banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda ==> {banda}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoes();
}

void ExibirTitulodaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void AvaliarUmaBanda()
{
    //digite qual baanda vai avaliar
    // Pesquisar se banda existir vamos atribuir uma nota
    // caso ela não existir então volta para o menu principal
    Console.Clear();
    ExibirTitulodaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a Banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoes();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("precione qualquer tecla para voltar para o Menu Principal");
        Console.ReadKey();
        ExibirOpcoes();
    }
}

void MediaDaBanda()
{
    Console.Clear();
    ExibirTitulodaOpcao("Exibindo a media de uma banda");
    Console.WriteLine("Digite o nome da banda que deseja exibir a media");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda foi de  {notasDaBanda.Average()}");
        Console.WriteLine("Digita uma tecla para voltar ao menu princiapl");
        Console.ReadKey();
        ExibirOpcoes();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("precione qualquer tecla para voltar para o Menu Principal");
        Console.ReadKey();
        ExibirOpcoes();
    }

}

ExibirOpcoes();

