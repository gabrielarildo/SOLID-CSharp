namespace SOLID.OCP.Solucao;

public class Order
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
}

public interface IPaymentProcessor
{
    void Process(Order order);
}

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public void Process(Order order) =>
        Console.WriteLine($"Pagamento via cartão de crédito: R$ {order.Amount}");
}

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void Process(Order order) =>
        Console.WriteLine($"Pagamento via PayPal: R$ {order.Amount}");
}

public class CashPaymentProcessor : IPaymentProcessor
{
    public void Process(Order order) =>
        Console.WriteLine($"Pagamento via dinheiro: R$ {order.Amount}");
}

// Novo comportamento adicionado sem alterar nenhuma classe existente.
public class BitcoinPaymentProcessor : IPaymentProcessor
{
    public void Process(Order order) =>
        Console.WriteLine($"Pagamento via Bitcoin: R$ {order.Amount}");
}

// SOLUÇÃO DO OCP: o processador depende de uma abstração (contrato),
// permitindo novas implementações via polimorfismo.
public class OrderProcessor
{
    private readonly IPaymentProcessor _paymentProcessor;

    public OrderProcessor(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void Process(Order order) => _paymentProcessor.Process(order);
}

public class Program
{
    public static void Main()
    {
        var order = new Order { Id = 42, Amount = 200m };

        var processor = new OrderProcessor(new CreditCardPaymentProcessor());
        processor.Process(order);

        // Novo método de pagamento adicionado sem modificar o processador principal.
        var bitcoinProcessor = new OrderProcessor(new BitcoinPaymentProcessor());
        bitcoinProcessor.Process(order);
    }
}
