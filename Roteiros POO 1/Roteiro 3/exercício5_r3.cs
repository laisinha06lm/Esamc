class ContaBancaria
{
    private string titular;
    public string Titular
    {
        get
        {
            return titular;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O titular da conta não pode ser nulo ou vazio.");
            }
            titular = value;
        }
    }
    public decimal Saldo { get; private set; }

    public ContaBancaria(string Titular)
    {
        this.Titular = Titular;
        Saldo = 0;
    }
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Não é possível depositar um valor negativo ou zero.");
        }
        else
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Não é possível sacar um valor negativo ou igual a zero");
        }
        else if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}");
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

            //conta.Saldo = -5000;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}