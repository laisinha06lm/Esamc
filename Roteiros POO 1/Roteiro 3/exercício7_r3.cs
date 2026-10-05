class Produto
{
    private string nome;
    private string codigo;
    private decimal preco;
    public int QuantidadeEstoque { get; private set; }
    public bool EstoqueBaixo
    {
        get
        {
            return QuantidadeEstoque <= 5;
        }
    }
    public Produto(string Nome, string  Codigo, decimal Preco, int quantidadeestoque)
    {
        if(quantidadeestoque < 0)
        {
            throw new ArgumentException("A quantidade em estoque não pode ser negativa.");
        }
        this.QuantidadeEstoque = quantidadeestoque;
        this.Nome = Nome;
        this.Codigo = Codigo;
        this.Preco = Preco;
    }

    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome do produto não pode ser nulo ou vazio.");
            }
            nome = value;
        }
    }

    public string Codigo
    {
        get
        {
            return codigo;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O código do produto não pode ser nulo ou vazio.");
            }
            codigo = value;
        }
    }

    public decimal Preco
    {
        get
        {
            return preco;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço do produto não pode ser negativo.");
            }
            preco = value;
        }
    }

    public void AdicionarEstoque(int quantidade)
    {
        if(quantidade < 0)
        {
            throw new ArgumentException("A quantidade a ser adicionada não pode ser negativa.");
        }
        QuantidadeEstoque += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if(quantidade < 0)
        {
            throw new ArgumentException("O estoque a ser removido não pode ser negativo.");
        }
        if(quantidade > QuantidadeEstoque)
        {
            throw new ArgumentException("O estoque a ser removido não pode ser maior que a quantidade em estoque.");
        }
        QuantidadeEstoque -= quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Produto 1", "COD001", 10.0m, 15);
        try
        {
            produto.AdicionarEstoque(20);
            Console.WriteLine(produto.QuantidadeEstoque);
            produto.RemoverEstoque(10);
            Console.WriteLine(produto.QuantidadeEstoque);
            Console.WriteLine(produto.EstoqueBaixo);
            //produto.QuantidadeEstoque = 500;
            produto.RemoverEstoque(30);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        try
        {
            Console.WriteLine(produto.QuantidadeEstoque);
            produto.RemoverEstoque(22);
            Console.WriteLine(produto.EstoqueBaixo);
            Produto produto2 = new Produto(" ", "COD002", 20.0m, 5);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}


// QuantidadeEstoque deve possuir private set em vez de set público, pois a quantidade em estoque não deve ser alterada diretamente de fora da classe
// O método AdicionarEstoque e RemoverEstoque são responsáveis por alterar a quantidade em estoque, garantindo que as regras de negócio
// sejam respeitadas.