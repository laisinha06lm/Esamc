class Produto
{
    private string nome;
    private decimal preco;

    public decimal Preco
    {
        get
        {
            return preco;
        }

        set
        {
            if(value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }

            preco = value;
        }
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
                throw new ArgumentException("O valor do nome não pode ser nulo ou vazio.");
            }
            
            nome = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();
        Produto produto2 = new Produto();
        Produto teste = new Produto();

        try
        {
            produto.Nome = "";

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        try
        {
            produto.Nome = "Camiseta";
            produto.Preco = 49.99m;
            Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco:C}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        try
        {
            produto2.Nome = "Calça";
            produto2.Preco = -100.00m;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        try
        {
            produto2.Preco = 100.00m;
            Console.WriteLine($"Produto: {produto2.Nome}, Preço: {produto2.Preco:C}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        try
        {
            teste.Nome = "Tênis";
            teste.Preco = 100.00m;
            Console.WriteLine($"Produto: {teste.Nome}, Preço: {teste.Preco:C}");
            teste.Preco = 250.00m;
            Console.WriteLine($"Produto: {teste.Nome}, Preço: {teste.Preco:C}");
            teste.Preco = -50.00m;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        try
        {
            teste.Nome = null;

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        try
        {
            teste.Nome = " ";
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}