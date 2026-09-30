class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando Pagamento....");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("O pagamento com cartão de crédito foi processado com sucesso!");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("O pagamento com boleto bancário foi processado com sucesso!");
    }
}

class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("O pagamento com pix foi processado com sucesso!");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<Pagamento> pagamentos = new List<Pagamento>();
        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());
        pagamentos.Add(new Pix());
        pagamentos.Add(new BoletoBancario());
        pagamentos.Add(new Pix());
        pagamentos.Add(new CartaoCredito());

        foreach (Pagamento pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
        }
    }
}