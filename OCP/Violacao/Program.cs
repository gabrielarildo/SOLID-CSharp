namespace SOLID.OCP.Violacao;

public class Order
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
}

public enum PaymentMethod
{
    CreditCard,
    PayPal,
    Cash
}

// VIOLAÇÃO DO OCP: para adicionar um novo método de pagamento,
// é necessário modificar esta classe, alterando o método principal.
public class OrderProcessor
{
    public void Process(Order order, PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.CreditCard:
                Console.WriteLine($"Pagamento via cartão de crédito: R$ {order.Amount}");
                break;
            case PaymentMethod.PayPal:
                Console.WriteLine($"Pagamento via PayPal: R$ {order.Amount}");
                break;
            case PaymentMethod.Cash:
                Console.WriteLine($"Pagamento via dinheiro: R$ {order.Amount}");
                break;
            default:
                throw new NotImplementedException($"Método de pagamento {(int)paymentMethod} não suportado.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        var order = new Order { Id = 42, Amount = 200m };
        var processor = new OrderProcessor();
        processor.Process(order, PaymentMethod.CreditCard);
    }
}
