Console.WriteLine("Name your goober");

Weapon Dagger = new()
{
    MinDamage = 5,
    MaxDamage = 12,
    Name="Dagger",
    Weight=1.2f
};
Consumable HealPot = new()
{
    UsesCurrent = 2,
    UsesMax = 3,
    Name="Healing Potion",
    Weight=0.4f
};


Character player = new()
{
    Backpack = new()
    {
        Items= [Dagger, HealPot]
    },
    Name=Console.ReadLine()
};



while (true)
{
    player.Backpack.Display();
    Console.ReadLine();
}

