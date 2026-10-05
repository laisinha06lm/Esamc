public class Veiculo
{
    public string Marca;
    public string Modelo;
    public int NumeroDeRodas;

    public void ExibirDados()
    {
        Console.WriteLine($"Marca do veículo: {Marca}");
        Console.WriteLine($"Modelo do veículo: {Modelo}");
        Console.WriteLine($"Número de rodas: {NumeroDeRodas}");
    }
}

public class Carro : Veiculo
{
    public int NumeroDePortas;
    public void ExibirDadosCarro()
    {
        ExibirDados();
        Console.WriteLine($"Número de portas: {NumeroDePortas}");
    }
}

public class Moto : Veiculo
{
    public bool PossuiBagageiro;
    public void ExibirDadosMoto()
    {
        ExibirDados();
        Console.WriteLine($"Possui bagageiro: {PossuiBagageiro}");
    }
}

public class Program
{
    public static void Main()
    {
        Carro carro = new Carro();
        carro.Marca = "Toyota";
        carro.Modelo = "Corolla";
        carro.NumeroDeRodas = 4;
        carro.NumeroDePortas = 4;
        Moto moto = new Moto();
        moto.Marca = "Honda";
        moto.Modelo = "CB500";
        moto.NumeroDeRodas = 2;
        moto.PossuiBagageiro = true;
        Console.WriteLine("Dados do Carro:");
        carro.ExibirDadosCarro();
        Console.WriteLine("\nDados da Moto:");
        moto.ExibirDadosMoto();
    }
}