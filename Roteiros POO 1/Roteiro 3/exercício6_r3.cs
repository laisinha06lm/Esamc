class Aluno
{
    private string nome;
    private double nota1;
    private double nota2;
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
                throw new ArgumentException("O nome do aluno não pode ser vazio.");
            }
            nome = value;
        }
    }

    public double Nota1
    {
        get
        {
            return nota1;
        }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            }
            nota1 = value;
        }
    }

    public double Nota2
    {
        get
        {
            return nota2;
        }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            }
            nota2 = value;
        }
    }
    public double Media
    {
        get
        {
            return (nota1 + nota2) / 2;
        }
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        try
        {
            aluno.Nome = "Maria";
            aluno.Nota1 = 8;
            aluno.Nota2 = 6;
            Console.WriteLine(aluno.Media);
            aluno.Nota2 = 10;
            Console.WriteLine(aluno.Media);
            aluno.Nome = "";
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            aluno.Nota1 = 11;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}