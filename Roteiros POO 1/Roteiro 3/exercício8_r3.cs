// 1. Qual regra do sistema pode ser quebrada?
// Como o saldo da conta está público para qualquer alteração e sem validação, é possível atribuir um valor negativo ao saldo,
// o que não faz sentido em um contexto bancário, pois uma conta não deveria ter saldo negativo sem uma lógica de crédito ou débito apropriada.

// 2.Como alterar a propriedade para impedir a alteração externa?
// Para impedir a alteração externa do saldo, podemos tornar o setter da propriedade privado, assim a propriedade só poderá ser modificada
// dentro da própria classe Conta.

// 3. Como o método Depositar() continuará conseguindo modificar o saldo?
// O método Depositar() continuará conseguindo modificar o saldo pois ele está dentro da classe Conta,
// e métodos dentro da mesma classe têm acesso a membros privados da classe, incluindo propriedades com setters privados.

// 4. Existe alguma situação em que get; set; público seria aceitável?
// Sim, em situações onde a propriedade representa um valor que pode ser livremente lido e modificado por qualquer parte do código
// sem restrições, como por exemplo, uma propriedade de configuração que não afeta a lógica de negócios ou integridade do sistema.

class Conta
{
    public decimal Saldo { get; private set; }
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do depósito deve ser positivo.");
        }
        Saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Conta conta = new Conta();
            //conta.Saldo = -999999
            conta.Depositar(500);
            Console.WriteLine(conta.Saldo);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}