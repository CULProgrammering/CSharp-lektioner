public class Tea : Drink
{
    public Tea(string name, decimal price) : base(name, price)
    {
    }

    public void PrintReceipt()
    {
        Console.WriteLine($"{Name}: {Price} kr (loose leaf)");
    }
}
