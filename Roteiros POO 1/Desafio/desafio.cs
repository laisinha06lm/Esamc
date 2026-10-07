class Veiculo
{
    private string placa;
    private string modelo;
    public DateTime HoraEntrada { get; private set; }
    public DateTime? HoraSaida { get; private set; }
    public decimal valorPago { get; private set; }

    public Veiculo(string placa, string modelo)
    {
        this.Placa = placa;
        this.Modelo = modelo;
        this.HoraEntrada = DateTime.Now;
        this.HoraSaida = null;
        this.valorPago = 0;
    }

    public string Placa
    {
        get
        {
            return placa;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A placa não pode ser nula ou vazia.");
            }
            placa = value;
        }
    }

    public string Modelo
    {
        get
        {
            return modelo;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O modelo não pode ser nulo ou vazio.");
            }
            modelo = value;
        }
    }
    public void RegistrarSaida()
    {
        if(HoraSaida != null)
        {
            throw new ArgumentException("Este veículo já registrou a saída.");
        }

        HoraSaida = DateTime.Now;
    }

    public void DefinirValorPago(decimal valor)
    {
        if(valor < 0)
        {
            throw new ArgumentException("O valor pago não pode ser negativo.");
        }
        valorPago = valor;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Placa: {placa}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Hora de Entrada: {HoraEntrada}");
        Console.WriteLine($"Hora de Saída: {HoraSaida?.ToString() ?? "Não registrada"}");
        Console.WriteLine($"Valor Pago: {valorPago:C}");
    }

}

class Estacionamento
{
    private List<Veiculo> veiculos;
    public Estacionamento()
    {
        veiculos = new List<Veiculo>();
    }

    public void RegistrarEntrada(Veiculo veiculo)
    {
        if(veiculos.Count >= 5)
        {
            throw new InvalidOperationException("O estacionamento está cheio. Não é possível registrar a entrada de mais veículos.");
        }
        if (veiculos.Any(v => v.Placa == veiculo.Placa))
        {
            throw new InvalidOperationException("Um veículo com a mesma placa já está registrado no estacionamento.");
        }
        veiculos.Add(veiculo);
    }

    public void RegistrarSaida(string placa)
    {
        Veiculo veiculo = veiculos.FirstOrDefault(v => v.Placa == placa);

        if (veiculo == null)
        {
            throw new InvalidOperationException("Veículo não encontrado no estacionamento.");
        }

        veiculo.RegistrarSaida();

        if (veiculo.HoraSaida < veiculo.HoraEntrada)
        {
            throw new InvalidOperationException("A hora de saída não pode ser anterior à hora de entrada.");
        }

        CalcularValorPago(placa);

        veiculo.ExibirInformacoes();

        veiculos.Remove(veiculo);
    }

    public void CalcularValorPago(string placa)
    {
        decimal valorHora = 10;

        Veiculo veiculo = veiculos.FirstOrDefault(v => v.Placa == placa);

        if (veiculo == null)
        {
            throw new ArgumentException("Veículo não encontrado no estacionamento.");
        }
        if (veiculo.HoraSaida == null)
        {
            throw new InvalidOperationException("O veículo ainda não registrou a saída.");
        }

        TimeSpan permanencia = veiculo.HoraSaida.Value - veiculo.HoraEntrada;

        decimal horasCobradas = (decimal)Math.Ceiling(permanencia.TotalHours) * valorHora;

        veiculo.DefinirValorPago(horasCobradas);
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();
        try
        {
            Veiculo veiculo1 = new Veiculo("ABC1234", "Fusca");
            estacionamento.RegistrarEntrada(veiculo1);
            Veiculo veiculo2 = new Veiculo("XYZ5678", "Gol");
            estacionamento.RegistrarEntrada(veiculo2);
            Veiculo veiculo3 = new Veiculo("LMN9012", "Civic");
            estacionamento.RegistrarEntrada(veiculo3);
            Veiculo veiculo4 = new Veiculo("DEF3456", "Corolla");
            estacionamento.RegistrarEntrada(veiculo4);
            Veiculo veiculo5 = new Veiculo("GHI7890", "Fiesta");
            estacionamento.RegistrarEntrada(veiculo5);
            Veiculo veiculo6 = new Veiculo("JKL1234", "Uno");
            estacionamento.RegistrarEntrada(veiculo6);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        try
        {
            estacionamento.RegistrarSaida("ABC1234");
            estacionamento.RegistrarSaida("ZZZ9999");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}