namespace SOLID.SRP.Violacao;

public class Order
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
}

// VIOLAÇÃO DO SRP: esta classe possui mais de uma responsabilidade.
// Ela calcula o total, salva o pedido e gera o relatório.
public class OrderService
{
    public decimal CalculateTotal(Order order) => order.Amount;

    public void Save(Order order)
    {
        // Simulação de persistência em banco de dados.
        Console.WriteLine($"Pedido {order.Id} salvo.");
    }

    public string GenerateReport(Order order) =>
        $"Relatório do Pedido {order.Id}: valor total - R$ {order.Amount}";
}

public class Program
{
    public static void Main()
    {
        var order = new Order { Id = 1, Amount = 150.50m };
        var service = new OrderService();

        Console.WriteLine($"Total: {service.CalculateTotal(order)}");
        service.Save(order);
        Console.WriteLine(service.GenerateReport(order));
    }
}
