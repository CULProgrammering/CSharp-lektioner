public class SmartSpeaker : SmartDevice
{
    public SmartSpeaker(string name) : base(name)
    {
    }

    public override void TurnOn()
    {
        Console.WriteLine($"{Name} plays a startup sound");
    }

    public void Report()
    {
        Console.WriteLine("Volume: 40%");
    }
}
