class Program
{
    static float ConverterTemperatura(string converter)
    {
        if(float.TryParse(converter, out float celsius))
        {
            return celsius;
        }

        throw new FormatException("Temperatura inválida");
    }
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Insira o valor da temperatura: ");
                string converter = Console.ReadLine();

                float temperatura = ConverterTemperatura(converter);

                Console.WriteLine($"Temperatura: {temperatura}ºC");
                break;
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}\n");
                Console.WriteLine("Tente novamente\n");
            }
        }
    }
}