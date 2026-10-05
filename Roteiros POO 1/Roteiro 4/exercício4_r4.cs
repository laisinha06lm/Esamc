public interface IVoar
{
    void Voar();
}

public interface INadar
{
    void Nadar();
}

public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O pato está voando.");
    }

    public void Nadar()
    {
        Console.WriteLine("O pato está nadando.");
    }
}

public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A águia está voando.");
    }
}

public class  Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O peixe está nadando.");
    }
}

public class Program
{
    public static void Main()
    {
        Pato pato = new Pato();
        pato.Voar();
        pato.Nadar();
        Aguia aguia = new Aguia();
        aguia.Voar();
        Peixe peixe = new Peixe();
        peixe.Nadar();
    }
}