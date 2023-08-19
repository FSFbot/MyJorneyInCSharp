public class Produto
{
    // Atributos
    private string _nome;
    private decimal _preco;
    private int _quantidadeEmEstoque;

    // Propriedades
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public decimal Preco
    {
        get { return _preco; }
        set 
        { 
            if(value >= 0)  // Garantir que o preço nunca seja negativo
                _preco = value; 
        }
    }

    public int QuantidadeEmEstoque
    {
        get { return _quantidadeEmEstoque; }
        private set
        {
            if (value >= 0)  // Garantir que a quantidade em estoque nunca seja negativa
                _quantidadeEmEstoque = value;
        }
    }

    // Construtor
    public Produto(string nome, decimal preco, int quantidadeEmEstoque)
    {
        _nome = nome;
        _preco = preco;
        _quantidadeEmEstoque = quantidadeEmEstoque > 0 ? quantidadeEmEstoque : 0;  // Inicializa com 0 se o valor for negativo
    }

    // Métodos
    public void Comprar(int quantidade)
    {
        if(quantidade > 0)
            _quantidadeEmEstoque += quantidade;
        else
            Console.WriteLine("Informe uma quantidade válida para comprar.");
    }

    public void Vender(int quantidade)
    {
        if (quantidade <= _quantidadeEmEstoque && quantidade > 0)
            _quantidadeEmEstoque -= quantidade;
        else
            Console.WriteLine("Quantidade insuficiente em estoque ou quantidade inválida.");
    }

    public void AumentarPreco(decimal valor)
    {
        if (valor > 0)
            _preco += valor;
        else
            Console.WriteLine("Informe um valor válido para aumento de preço.");
    }

    public void DiminuirPreco(decimal valor)
    {
        if (valor > 0 && (_preco - valor) >= 0)
            _preco -= valor;
        else
            Console.WriteLine("Informe um valor válido para diminuição de preço ou valor muito alto que tornaria o preço negativo.");
    }
}
