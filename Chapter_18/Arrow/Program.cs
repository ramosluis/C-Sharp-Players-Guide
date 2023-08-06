while (true)
{
    Console.Clear();
    Console.Write(@"What type of arrowhead would you like?
1 - Steel
2 - Wood
3 - Obsidian
0 - Quit

> ");

    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == 0) { break; }

    Arrowhead arrowhead = answer switch
    {
        1 => Arrowhead.Steel,
        2 => Arrowhead.Wood,
        3 => Arrowhead.Obsidian,
        _ => Arrowhead.Steel
    };

    Console.Write(@"What type of fletching would you like?
1 - Plastic
2 - Turkey Feathers
3 - Goose Feathers
0 - Quit

> ");

    answer = Convert.ToInt32(Console.ReadLine());

    if(answer == 0) { break; }

    Fletching fletching = answer switch
    {
        1 => Fletching.Plastic,
        2 => Fletching.TurkeyFeathers,
        3 => Fletching.GooseFeathers,
        _ => Fletching.Plastic
    };

    int length = 0;

    while (true)
    {
        Console.Write("How long would you like the shaft to be (enter 0 to quit)? ");
        length = Convert.ToInt32(Console.ReadLine());

        if (length == 0) { break; }

        if (length < 60 || length > 100)
        {
            Console.WriteLine("Invalid length, please input a length between 60 and 100 cm.");
            continue;
        }

        break;
    }
    if (length == 0) { break; }

    Arrow arrow = new Arrow(arrowhead, fletching, length);

    Console.WriteLine($"The cost for this arrow is ${arrow.GetCost()}.");
    Console.ReadLine();
}


class Arrow
{
    private Arrowhead _arrowhead;
    private Fletching _fletching;
    private int _length;

    public Arrow(Arrowhead arrowhead, Fletching fletching, int length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public Arrowhead GetArrowhead() { return _arrowhead; }
    public Fletching GetFletching() { return _fletching; }
    public int GetLength() { return _length; }

    public float GetCost()
    {
        return ArrowheadCost() + FletchingCost() + LengthCost();
    }

    private float LengthCost()
    {
        return 0.05F * _length;
    }

    private float FletchingCost()
    {
        float cost = _fletching switch
        {
            Fletching.Plastic => 10.0F,
            Fletching.TurkeyFeathers => 5.0F,
            Fletching.GooseFeathers => 3.0F,
            _ => 10.0F
        };

        return cost;
    }

    private float ArrowheadCost()
    {
        float cost = _arrowhead switch
        {
            Arrowhead.Steel => 10.0F,
            Arrowhead.Wood => 3.0F,
            Arrowhead.Obsidian => 5.0F,
            _ => 10.0F
        };

        return cost;
    }
}

enum Arrowhead
{
    Steel,
    Wood,
    Obsidian
}

enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}