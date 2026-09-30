public class SmartDevice
{
    protected string Name;

    public SmartDevice(string name)
    {
        Name = name;
    }

    public abstract void TurnOn();

    public virtual void Report()
    {
        Console.WriteLine($"{Name} is online");
    }
}
