using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Insira seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Insira a data e hora de seu compromisso (siga o formato: dd/MM/yyyy HH:mm): ");
        DateTime compromisso = DateTime.Parse(Console.ReadLine());

        TimeSpan diasRestantes = compromisso - DateTime.Now;

        string diaDaSemana = compromisso.ToString("dddd", new CultureInfo("pt-BR"));

        string mensagem = string.Format("Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3} às {4}", 
            nome,diasRestantes.Days ,diaDaSemana,compromisso.ToString("dd/MM/yyyy"), compromisso.ToString("HH:mm"));

        Console.WriteLine(mensagem);
    }
}