while (true)
{
    Arrow arrow;
    Console.Clear();
    Console.WriteLine(@"What type of arrow would you like?
1 - Elite Arrow
2 - Beginner Arrow
3 - Marksman Arrow
4 - Custom Arrow
0 - Quit");

    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 0) { break; }

    switch (answer)
    {
        case 1:
            arrow = Arrow.CreateEliteArrow();
            Console.WriteLine($"The cost for this arrow is ${arrow.GetCost()}.");
            break;
        case 2:
            arrow = Arrow.CreateBeginnerArrow();
            Console.WriteLine($"The cost for this arrow is ${arrow.GetCost()}.");
            break;
        case 3:
            arrow = Arrow.CreateMarksmanArrow();
            Console.WriteLine($"The cost for this arrow is ${arrow.GetCost()}.");
            break;
        default:
            Console.Write(@"What type of arrowhead would you like?
1 - Steel
2 - Wood
3 - Obsidian
0 - Quit

> ");

            answer = Convert.ToInt32(Console.ReadLine());
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
            if (answer == 0) { break; }

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

            arrow = new Arrow(arrowhead, fletching, length);

            Console.WriteLine($"The cost for this arrow is ${arrow.GetCost()}.");
            break;
    }

    Console.ReadLine();
}


class Arrow
{
    private Arrowhead ArrowheadType { get; init; }
    private Fletching ArrowFletching { get; init; }
    private int ArrowLength { get; init; }

    public Arrow(Arrowhead arrowhead, Fletching fletching, int length)
    {
        ArrowheadType = arrowhead;
        ArrowFletching = fletching;
        ArrowLength = length;
    }

    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);

    public float GetCost()
    {
        return ArrowheadCost() + FletchingCost() + LengthCost();
    }

    private float LengthCost()
    {
        return 0.05F * ArrowLength;
    }

    private float FletchingCost()
    {
        float cost = ArrowFletching switch
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
        float cost = ArrowheadType switch
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