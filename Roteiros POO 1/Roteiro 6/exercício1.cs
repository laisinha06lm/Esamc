class Produto
{
    private string nome;
    private decimal preco;
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
                throw new ArgumentException("O nome do produto não pode estar vazio!");
            }

            nome = value;
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
            if(value <= 0)
            {
                throw new ArgumentException("O preço não pode ser menor ou igual a 0!");
            }
            
            preco = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        while (true)
        {
            try
            {
                Console.Write("Insira o nome do produto: ");
                produto.Nome = Console.ReadLine();

                break;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}\n");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Insira o preço do produto: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                break;
            }
            catch(FormatException)
            {
                Console.WriteLine("\nDigite um preço numérico válido\n");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}\n");
            }
        }

        Console.WriteLine($"\nProduto: {produto.Nome} | Preço: {produto.Preco:C}");
    }
}