namespace SOLID.ISP.Solucao;

public interface IWorker
{
    void Work();
}

public interface IPerson
{
    void Eat();
    void Sleep();
}

// SOLUÇÃO DO ISP: a interface foi dividida em contratos menores e específicos.
// O robô implementa apenas o que faz de fato, e o humano também.
public class HumanWorker : IWorker, IPerson
{
    public void Work() => Console.WriteLine("Humano trabalhando.");

    public void Eat() => Console.WriteLine("Humano comendo.");

    public void Sleep() => Console.WriteLine("Humano dormindo.");
}

public class RobotWorker : IWorker
{
    public void Work() => Console.WriteLine("Robô trabalhando.");
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

        IPerson person = new HumanWorker();
        person.Eat();
        person.Sleep();
    }
}
