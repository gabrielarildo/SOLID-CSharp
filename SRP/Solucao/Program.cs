namespace SOLID.SRP.Solucao;

public class Order
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
}

// SOLUÇÃO DO SRP: cada responsabilidade foi extraída para uma classe dedicada.
public class OrderCalculator
{
    public decimal CalculateTotal(Order order) => order.Amount;
}

public class OrderRepository
{
    private readonly List<Order> _orders = new();

    public void Save(Order order)
    {
        _orders.Add(order);
        Console.WriteLine($"Pedido {order.Id} salvo.");
    }
}

public class OrderReportGenerator
{
    public string Generate(Order order) =>
        $"Relatório do Pedido {order.Id}: valor total - R$ {order.Amount}";
}

public class Program
{
    public static void Main()
    {
        var order = new Order { Id = 1, Amount = 150.50m };
        var calculator = new OrderCalculator();
        var repository = new OrderRepository();
        var reportGenerator = new OrderReportGenerator();

        Console.WriteLine($"Total: {calculator.CalculateTotal(order)}");
        repository.Save(order);
        Console.WriteLine(reportGenerator.Generate(order));
    }
}
