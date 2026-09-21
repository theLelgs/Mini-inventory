public class Inventory
{
    public List<Item> Items;
    public void Display()
    {
        foreach (Item item in Items)
        {
            Console.WriteLine($"Item: {item.Name}");
        }
    }
}