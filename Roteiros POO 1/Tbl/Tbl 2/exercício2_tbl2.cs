abstract class Funcionario
{
    public abstract decimal CalcularSalario();
}

class Gerente : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 15000.00m;
    }
}

class Programador : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 13000.00m;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Funcionario gerente = new Gerente();
        Funcionario programador = new Programador();
        Console.WriteLine($"Salário do Gerente: {gerente.CalcularSalario():C}");
        Console.WriteLine($"Salário do Programador: {programador.CalcularSalario():C}");

        List<Funcionario> funcionarios = new List<Funcionario>();
        funcionarios.Add(new Gerente());
        funcionarios.Add(new Programador());

        foreach(Funcionario funcionario in funcionarios)
        {
            Console.WriteLine($"Salário: {funcionario.CalcularSalario():C}");
        }
    }
}