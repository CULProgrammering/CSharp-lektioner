public class Potion : Item, ISellable
{
    public Potion(string name) : base(name)
    {
    }

    public override void Use()
    {
        Console.WriteLine($"You drink the {Name}");
    }

    private void Sell()
    {
        Console.WriteLine($"Sold {Name} for 10 gold");
    }
}
