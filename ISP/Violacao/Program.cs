namespace SOLID.ISP.Violacao;

public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class HumanWorker : IWorker
{
    public void Work() => Console.WriteLine("Humano trabalhando.");

    public void Eat() => Console.WriteLine("Humano comendo.");

    public void Sleep() => Console.WriteLine("Humano dormindo.");
}

public class RobotWorker : IWorker
{
    public void Work() => Console.WriteLine("Robô trabalhando.");

    public void Eat() => throw new NotSupportedException("Robôs não comem.");

    public void Sleep() => throw new NotSupportedException("Robôs não dormem.");
}

public class Program
{
    public static void Main()
    {
        IEnumerable<IWorker> workers = new List<IWorker>
        {
            new HumanWorker(),
            new RobotWorker()
        };

        foreach (var worker in workers)
        {
            worker.Work();
        }
    }
}
