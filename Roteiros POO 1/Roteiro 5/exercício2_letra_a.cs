class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase com espaços no início e no final, e com as palavras separadas por vírgulas: ");
        string frase = Console.ReadLine();

        string fraseSemEspacos = frase.Trim();
        Console.WriteLine("Frase sem espaços no início e no final: " + fraseSemEspacos);

        string[] palavras = fraseSemEspacos.Split(',');
        Console.WriteLine("Frase separada em palavras:");

        foreach (string palavra in palavras)
        {
            Console.WriteLine(palavra);
        }

        string fraseSubstituida = fraseSemEspacos.Replace("Olá", "Hi");
        Console.WriteLine("Frase com substituição: " + fraseSubstituida);

        bool fraseComecaCom = fraseSemEspacos.StartsWith("Olá");
        Console.WriteLine($"Frase começa com 'Olá': {fraseComecaCom}");

        bool fraseTerminaCom = fraseSemEspacos.EndsWith("obrigada");
        Console.WriteLine($"Frase termina com 'obrigada': {fraseTerminaCom}");
    }
}