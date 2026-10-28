class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"O número inteiro inserido foi: {numero}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nValor inválido. Por favor, digite um número inteiro.\n");
            }
        }
    }
}