List<Drink> drinks = new List<Drink>();
drinks.Add(new Coffee("Latte", 45, 2));
drinks.Add(new Tea("Earl Grey", 30));

foreach (Drink d in drinks)
{
    d.PrintReceipt();
}

Drink first = drinks[0];
Console.WriteLine($"Size of first drink: {first.Size}");
Console.WriteLine($"Name of first drink: {first.Name}");
