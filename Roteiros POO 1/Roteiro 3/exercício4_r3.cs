class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area
    {
        get
        {
            return Largura * Altura;
        }
    }
}

class Program
{
    static void Main()
    {
        Retangulo retangulo = new Retangulo();
        retangulo.Altura = 5.0;
        retangulo.Largura = 10.0;
        Console.WriteLine($"Área: {retangulo.Area}");
        retangulo.Largura = 20;
        Console.WriteLine($"Área: {retangulo.Area}");
    }
}