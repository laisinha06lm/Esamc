public class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string mensagem) : base(mensagem) { }

}

public class Program
{
    public static void VerificarIdade(int idade)
    {
        if(idade < 18)
        {
            throw new IdadeInvalidaException("Erro: Idade mínima para acesso é 18 anos.");
        }

        Console.WriteLine("Acesso permitido.");
    }
    public static void Main()
    {
        try
        {
            Console.Write("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            VerificarIdade(idade);
        }
        catch(FormatException)
        {
            Console.WriteLine("Insira um valor válido");
        }
        catch(IdadeInvalidaException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}