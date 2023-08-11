Pack pack = new Pack(10, 25, 20);

while(true)
{
    Console.Clear();
    Console.Write(@$"Which of the following items would you like to add to your pack?
1 - Arrow
2 - Bow
3 - Rope
4 - Water
5 - Food
6 - Sword
0 - Quit

Pack info: Items ({pack.NumberOfItems}/{pack.MaxItems}) Weight ({pack.Weight:#.##}/{pack.MaxWeight:#.##})  Volume ({pack.Volume:#.##}/{pack.MaxVolume:#.##})
{pack.ToString()}

> ");

    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 0) break;

    switch (answer)
    {
        case 1:
            if (!pack.Add(new Arrow()))
            { Console.WriteLine("Item can't be added, pack limits reached."); Console.ReadLine(); }
                break;
        case 2:
            if (!pack.Add(new Bow()))
            { Console.WriteLine("Item can't be added, pack limits reached."); Console.ReadLine(); }
                break;
        case 3:
            if (!pack.Add(new Rope()))
            { Console.WriteLine("Item can't be added, pack limits reached."); Console.ReadLine(); }
                break;
        case 4:
            if (!pack.Add(new Water()))
            { Console.WriteLine("Item can't be added, pack limits reached."); Console.ReadLine(); }
                break;
        case 5:
            if (!pack.Add(new Food()))
            { Console.WriteLine("Item can't be added, pack limits reached."); Console.ReadLine(); }
                break;
        case 6:
            if (!pack.Add(new Sword()))
            { Console.WriteLine("Item can't be added, pack limits reached."); Console.ReadLine(); }
                break;
        default:
            Console.WriteLine("I don't recognize that item.");
            Console.ReadLine();
            break;
    }
}

public class InventoryItem
{
    public double Weight { get; protected set; }
    public double Volume { get; protected set; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Arrow : InventoryItem
{
    public Arrow() : base(0.1, 0.05) { }

    public override string ToString()
    {
        return "Arrow";
    }
}

public class Bow : InventoryItem
{
    public Bow() : base(1, 4) { }

    public override string ToString()
    {
        return "Bow";
    }
}

public class Rope : InventoryItem
{
    public Rope () : base(1, 1.5) { }

    public override string ToString()
    {
        return "Rope";
    }
}

public class Water : InventoryItem
{
    public Water () : base(2, 3) { }

    public override string ToString()
    {
        return "Water";
    }
}

public class Food : InventoryItem
{
    public Food() : base(1, 0.5) { }

    public override string ToString()
    {
        return "Food";
    }
}

public class Sword : InventoryItem
{
    public Sword() : base(5, 3) { }

    public override string ToString()
    {
        return "Sword";
    }
}

public class Pack
{
    public int MaxItems { get; }
    public double MaxWeight { get; }
    public double MaxVolume { get; }

    private InventoryItem[] _items;
    public int NumberOfItems { get; private set; }
    public double Weight { get; private set; }
    public double Volume { get; private set; }

    public Pack(int maxItems, double maxWeight, double maxVolume)
    {
        MaxItems = maxItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        NumberOfItems = 0;
        Weight = 0;
        Volume = 0;
        _items = new InventoryItem[MaxItems];
    }

    public bool Add(InventoryItem item)
    {
        if(NumberOfItems + 1 > MaxItems ||
            Weight + item.Weight > MaxWeight ||
            Volume + item.Volume > MaxVolume)
        {
            return false;
        }

        _items[NumberOfItems++] = item;
        Weight += item.Weight;
        Volume += item.Volume;

        return true;
    }

    public override string ToString() 
    {
        if (_items[0] == null)
        {
            return "Pack is empty.";
        }

        string contents = "Pack containing";

        foreach(InventoryItem item in _items)
        {
            if (item != null)
                contents += " " + item.ToString();
        }

        return contents;
    }
}