class Program
{
    static void Main()
    {
        Console.Write("Insira o valor do Capital Inicial: R$ ");
        decimal capitalInicial = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Insira a taxa de juros mensal (em %): ");
        decimal taxaJuros = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Insira o números de meses: ");
        int meses = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira a meta de Lucro: R$ ");
        decimal metaLucro = Convert.ToDecimal(Console.ReadLine());

        double taxaDouble = (double)taxaJuros / 100.0;

        double montante = (double)capitalInicial * Math.Pow(1 + taxaDouble, meses);

        decimal lucro = (decimal)montante - capitalInicial;
        lucro = Math.Round(lucro, 2);

        Console.WriteLine($"O montante final é: R$ {montante:F2}");
        Console.WriteLine($"O lucro obtido é: R$ {lucro:F2}");

        if(lucro > metaLucro)
        {
            Console.WriteLine("A meta de lucro foi superada!");
        }
        else if(lucro == metaLucro)
        {
            Console.WriteLine("A meta de lucro foi atingida!");
        }
        else
        {
            Console.WriteLine("A meta de lucro não foi atingida");
        }
    }
}