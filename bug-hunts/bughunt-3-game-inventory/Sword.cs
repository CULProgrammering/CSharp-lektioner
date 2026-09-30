public class Sword : ISellable, Item
{
    public Sword(string name) : base(name)
    {
    }

    public override void Use()
    {
        Console.WriteLine($"You swing the {Name}");
    }

    public override void Sell()
    {
        Console.WriteLine($"Sold {Name} for 50 gold");
    }
}
