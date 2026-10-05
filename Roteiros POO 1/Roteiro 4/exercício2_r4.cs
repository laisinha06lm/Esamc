public class Pessoa
{
    public string Nome;
}

public class Casa
{
    private Pessoa morador;

    public void AdicionarMorador(Pessoa pessoa)
    {
        morador = pessoa;
    }

    public void ExibirMorador()
    {
        if (morador != null)
        {
            Console.WriteLine($"O morador da casa é: {morador.Nome}");
        }
        else
        {
            Console.WriteLine("A casa não tem morador.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Inês";

        Casa casa = new Casa();
        casa.AdicionarMorador(pessoa);
        casa.ExibirMorador();
    }
}