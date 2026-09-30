public class QuestItem : Item
{
    public QuestItem(string name) : base(name)
    {
    }

    public override void Use()
    {
        Console.WriteLine($"The {Name} glows faintly");
    }
}
