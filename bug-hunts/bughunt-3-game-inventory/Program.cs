Potion potion = new Potion("Health Potion");
Sword sword = new Sword("Iron Sword");
QuestItem key = new QuestItem("Ancient Key");

List<Item> inventory = new List<Item>();
inventory.Add(potion);
inventory.Add(sword);
inventory.Add(key);

foreach (Item i in inventory)
{
    i.Use();
}

List<ISellable> sellables = new List<ISellable>();
sellables.Add(potion);
sellables.Add(sword);
sellables.Add(key);

foreach (ISellable s in sellables)
{
    s.Sell();
}
