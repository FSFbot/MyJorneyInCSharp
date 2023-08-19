class Program{
    public static void Main(string[] args){
         // Criando uma instância do Produto
            Produto celular = new Produto("Smartphone XYZ", 1000m, 50); // 1000m indica um valor decimal (o preço).

            // Mostrando informações iniciais
            Console.WriteLine($"Produto: {celular.Nome}");
            Console.WriteLine($"Preço: {celular.Preco:C}");  // :C formatará o preço como moeda
            Console.WriteLine($"Quantidade em estoque: {celular.QuantidadeEmEstoque}");

            // Comprando mais unidades do produto
            celular.Comprar(10);
            Console.WriteLine($"Quantidade após compra: {celular.QuantidadeEmEstoque}");

            // Vendendo algumas unidades do produto
            celular.Vender(15);
            Console.WriteLine($"Quantidade após venda: {celular.QuantidadeEmEstoque}");

            // Aumentando o preço
            celular.AumentarPreco(100m);
            Console.WriteLine($"Preço após aumento: {celular.Preco:C}");

            // Diminuindo o preço
            celular.DiminuirPreco(50m);
            Console.WriteLine($"Preço após diminuição: {celular.Preco:C}");

            // Tentando vender mais unidades do que disponíveis
            celular.Vender(100);
            Console.WriteLine($"Quantidade após tentativa de venda excedente: {celular.QuantidadeEmEstoque}");
    }
}
