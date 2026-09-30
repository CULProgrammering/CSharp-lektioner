public class SmartLamp : SmartDevice
{
    public SmartLamp(string name) : base(name)
    {
    }

    public void SwitchOn()
    {
        Console.WriteLine($"{Name} glows warm white");
    }
}
