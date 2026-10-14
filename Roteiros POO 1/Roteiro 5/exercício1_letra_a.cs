class Program
{
    static void Main()
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o {i + 1} número decimal: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"Número Original: {num}");
            Console.WriteLine($"Arredondamento Padrão: {Math.Round(num)}");
            Console.WriteLine($"Arredondamento pra baixo: {Math.Floor(num)}");
            Console.WriteLine($"Arredondamento pra cima: {Math.Ceiling(num)}");
            Console.WriteLine($"Truncamento: {Math.Truncate(num)}");
        }
    }
}
