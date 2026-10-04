class Pessoa
{
    public string Nome { get; private set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Pessoa(string Nome)
    {
        this.Nome = Nome;
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa("Maria");
        //pessoa.Nome = "Inês"; --> Não é possível atribuir um valor a propriedade somente leitura
        pessoa.Idade = 30;
        pessoa.Email = "maria@example.com";
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Email: {pessoa.Email}");
        pessoa.Idade = 31;
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Email: {pessoa.Email}");
    }
}