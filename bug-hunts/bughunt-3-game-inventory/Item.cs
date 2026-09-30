public abstract class Item
{
    protected string Name;

    public Item(string name)
    {
        Name = name;
    }

    public abstract void Use();
}
