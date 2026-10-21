class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Insira seu CPF: ");
            string cpf = Console.ReadLine();

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            bool Possui11Digitos = cpf.Length == 11;
            if (!Possui11Digitos)
            {
                throw new ArgumentException("O CPF deve conter 11 dígitos.");
            }

            for (int i = 0; i < cpf.Length; i++)
            {
                if (!char.IsDigit(cpf[i]))
                {
                    throw new ArgumentException("O CPF deve conter apenas números.");
                }
            }

            string cpfFormatado = cpf.Substring(0, 3) + "." +
                                  cpf.Substring(3, 3) + "." +
                                  cpf.Substring(6, 3) + "-" +
                                  cpf.Substring(9, 2);

            Console.WriteLine($"CPF Formatado: {cpfFormatado}");

        }
        catch(ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}