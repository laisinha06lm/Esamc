class Program
{
    static void Main()
    {
        string produto1 = "Teclado";
        decimal precoP1 = 120.00m;
        int quantidadeP1 = 2;

        string produto2 = "Monitor";
        decimal precoP2 = 1500.00m;
        int quantidadeP2 = 2;

        string produto3 = "Mouse";
        decimal precoP3 = 80.00m;
        int quantidadeP3 = 1;

        decimal total1 = precoP1 * quantidadeP1;
        decimal total2 = precoP2 * quantidadeP2;
        decimal total3 = precoP3 * quantidadeP3;

        decimal subtotal = total1 + total2 + total3;
        decimal desconto = subtotal * 0.10m;
        decimal totalFinal = subtotal - desconto;

        Console.WriteLine($"Lista de Produtos".PadLeft(43));
        Console.WriteLine(new string('-', 70));

        Console.WriteLine($"{"Produto",-15} {"Preço",15} {"Quantidade",12} {"Total",12}");
        Console.WriteLine(new string('-', 70));

        Console.WriteLine($"{produto1, -15} {precoP1,15:C} {quantidadeP1,10:D4} {total1,15:C}");
        Console.WriteLine($"{produto2,-15} {precoP2,15:C} {quantidadeP2,10:D4} {total2,15:C}");
        Console.WriteLine($"{produto3,-15} {precoP3,15:C} {quantidadeP3,10:D4} {total3,15:C}");

        Console.WriteLine(new string ('-', 70));

        Console.WriteLine($"{"Subtotal:",-22}{subtotal,15:N}");
        Console.WriteLine($"Desconto ({0.10m:P}): {desconto,16:F2}");
        Console.WriteLine($"{"Total final:",-22}{totalFinal,15:C}");

        Console.WriteLine(new string('-', 70));
    }
}