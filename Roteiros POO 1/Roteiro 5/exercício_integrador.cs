class Program
{
    static void Main()
    {
        try
        {

            Console.WriteLine("Cadastro De Evento\n".PadLeft(43));

            Console.WriteLine("Insira as informações abaixo:\n");

            Console.Write("Nome do Evento: ");
            string nomeEvento = Console.ReadLine();

            Console.Write("Data do evento (dd/MM/yyyy): ");
            DateTime dataEvento = DateTime.Parse(Console.ReadLine());

            Console.Write("Valor do Ingresso: R$ ");
            decimal valorIngresso = Convert.ToDecimal(Console.ReadLine());

            if(valorIngresso < 0)
            {
                throw new ArgumentException("O valor do ingresso não pode ser negativo!");
            }

            Console.Write("Categoria do ingresso(Vip,Comum): ");
            string categoria = Console.ReadLine().ToUpper().Trim();

            decimal desconto = 0m;

            if (categoria.Contains("VIP"))
            {
                categoria = "VIP";
                desconto = 0.10m;
            }
            else if (categoria.Contains("COMUM"))
            {
                categoria = "COMUM";
                desconto = 0.05m;
            }
            else
            {
                throw new ArgumentException("Categoria Inválida!");
            }

            decimal valorFinal = Math.Round(valorIngresso * (1 - desconto), 2);

            DateTime hoje = DateTime.Today;
            int diasRestantes = (dataEvento.Date - hoje).Days;

            if(diasRestantes < 0)
            {
                Console.WriteLine("A data do Evento já passou!");
                return;
            }

            Console.WriteLine("\n" + new string ('-', 55));

            Console.WriteLine("Ingresso".PadLeft(30));

            Console.WriteLine(new string('=', 55));

            Console.WriteLine(
                String.Format("{0,-20} {1,-30}", "EVENTO:", nomeEvento)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30}", "DATA:", dataEvento.ToString("dd/MM/yyyy"))
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30}", "CATEGORIA:", categoria)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30:C}", "VALOR ORIGINAL:", valorIngresso)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30:P0}", "DESCONTO:", desconto)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30:C}", "VALOR FINAL:", valorFinal)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30}", "DIAS RESTANTES:", diasRestantes)
            );

            Console.WriteLine(new string('-', 55));

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Formato inválido: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}