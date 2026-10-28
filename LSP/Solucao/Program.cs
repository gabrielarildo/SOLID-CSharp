namespace SOLID.LSP.Solucao;

public class Bird
{
    public string Name { get; }

    protected Bird(string name) => Name = name;

    public override string ToString() => Name;
}

public interface IFlyable
{
    void Fly();
}

public class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }

    public void Fly() => Console.WriteLine($"{Name} está voando.");
}

public class Penguin : Bird
{
    public Penguin(string name) : base(name) { }

    public void Swim() => Console.WriteLine($"{Name} está nadando.");
}

public class Program
{
    public static void Main()
    {
        IFlyable flyer = new Sparrow("Espaço");
        flyer.Fly();

        Bird penguin = new Penguin("Pinguim");
        Console.WriteLine(penguin);
        var swimmingBird = (Penguin)penguin;
        swimmingBird.Swim();
    }
}
