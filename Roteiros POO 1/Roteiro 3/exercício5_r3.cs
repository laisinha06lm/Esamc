class ContaBancaria
{
    public string Titular { get; set; }
    private decimal saldo;

    public ContaBancaria(string Titular)
    {
        if(string.IsNullOrWhiteSpace(Titular))
        {
            throw new ArgumentException("O titular da conta não pode ser nulo ou vazio.");
        }
        this.Titular = Titular;
        saldo = 0;
    }

    public decimal Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            throw new ArgumentException("Não é possível alterar o saldo diretamente. Use os métodos Depositar e Sacar para modificar o saldo.");
        }
    }

    public void Depositar(decimal valor)
    {
        if(valor <= 0)
        {
            Console.WriteLine("Não é possível depositar um valor negativo ou zero.");
        }
        else
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Novo saldo: {saldo:C}");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Não é possível sacar um valor negativo ou igual a zero");
        }
        else if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
        else
        {
            saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {saldo:C}");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            ContaBancaria conta = new ContaBancaria("Carlos");
            conta.Depositar(1000);
            conta.Sacar(250);
            Console.WriteLine(conta.Saldo);

            conta.Saldo = -5000;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}