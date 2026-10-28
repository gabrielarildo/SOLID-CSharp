namespace SOLID.LSP.Violacao;

public abstract class Bird
{
    public string Name { get; }

    protected Bird(string name) => Name = name;

    public abstract void Fly();
}

public class Sparrow : Bird
{
    public Sparrow(string name) : base(name) { }

    public override void Fly() => Console.WriteLine($"{Name} está voando.");
}

public class Penguin : Bird
{
    public Penguin(string name) : base(name) { }

    public override void Fly() => throw new NotSupportedException($"{Name} não sabe voar.");
}

public class Program
{
    public static void Main()
    {
        Bird bird = new Sparrow("Espaço");
        bird.Fly();

        // Esperado: o pinguim voa? Não! Ele não deveria herdar o comportamento de voar.
        Bird penguin = new Penguin("Pinguim");
        penguin.Fly();
    }
}
