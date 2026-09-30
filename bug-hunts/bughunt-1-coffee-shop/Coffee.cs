public class Coffee : Drink
{
    private int _shots;

    public new string Size = "Large";

    public Coffee(string name, decimal price, int shots)
    {
        _shots = shots;
    }

    public override void PrintReceipt()
    {
        Console.WriteLine($"{Name} ({_shots} shots): {Price} kr");
    }
}
