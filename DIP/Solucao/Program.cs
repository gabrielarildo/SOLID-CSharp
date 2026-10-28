namespace SOLID.DIP.Solucao;

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

public class StripeGateway : IPaymentGateway
{
    public void Charge(Payment payment) => Console.WriteLine($"Pagamento via Stripe: R$ {payment.Amount}");
}

// SOLUÇÃO DO DIP: a classe de alto nível depende de uma abstração (interface),
// recebendo a implementação por injeção de dependência.
public class PaymentService
{
    private readonly IPaymentGateway _gateway;

    public PaymentService(IPaymentGateway gateway)
    {
        _gateway = gateway;
    }

    public void Process(Payment payment) => _gateway.Charge(payment);
}

public class Program
{
    public static void Main()
    {
        new PaymentService(new PayPalGateway()).Process(new Payment { Id = 1, Amount = 100m });
        new PaymentService(new StripeGateway()).Process(new Payment { Id = 2, Amount = 250m });
    }
}
