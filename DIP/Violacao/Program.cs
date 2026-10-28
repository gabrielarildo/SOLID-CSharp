namespace SOLID.DIP.Violacao;

public class Payment
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
}

public interface IPaymentGateway
{
    void Charge(Payment payment);
}

public class PayPalGateway : IPaymentGateway
{
    public void Charge(Payment payment) => Console.WriteLine($"Pagamento via PayPal: R$ {payment.Amount}");
}

public class PaymentService
{
    private readonly IPaymentGateway _gateway = new PayPalGateway();

    public void Process(Payment payment) => _gateway.Charge(payment);
}

public class Program
{
    public static void Main()
    {
        var service = new PaymentService();
        service.Process(new Payment { Id = 1, Amount = 100m });
    }
}
