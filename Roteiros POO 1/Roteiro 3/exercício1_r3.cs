class ContaBancaria
{
    private decimal saldo;

    public ContaBancaria()
    {
        saldo = 1000;
    }
    public decimal Saldo
    {
        get
        {

            return saldo;

        }

        set
        {
          throw new ArgumentException("O saldo não pode ser alterado");
          
        }
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        try
        {
            Console.WriteLine($"Saldo atual: {conta.Saldo}");
            conta.Saldo = 5000;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");

        }
    }
}

// Saldo deve ser somente leitura para o código externo,
// pois a alteração do saldo deve ser controlada pela própria classe,
// evitando que outras partes do programa modifiquem seu valor diretamente.
