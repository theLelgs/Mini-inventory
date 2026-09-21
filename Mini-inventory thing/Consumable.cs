public class Consumable : Item
{
    public int UsesMax;
    public int UsesCurrent;
    public void Use(Character target)
    {
        target.Hp+=10;
    }
}