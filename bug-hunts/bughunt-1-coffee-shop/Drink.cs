public class Drink
{
    protected string Name;
    protected decimal Price;

    public virtual string Size { get; set; } = "Medium";

    public Drink(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void PrintReceipt()
    {
        Console.WriteLine($"{Name}: {Price} kr");
    }
}
