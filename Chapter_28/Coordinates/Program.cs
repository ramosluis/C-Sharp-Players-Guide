Coordinate coord1 = new Coordinate(0, 0);
Coordinate coord2 = new Coordinate(1, 1);
Coordinate coord3 = new Coordinate(0, 1);
Coordinate coord4 = new Coordinate(1, 0);
Coordinate coord5 = new Coordinate(2, 1);
Coordinate coord6 = new Coordinate(1, 2);

Console.WriteLine(coord1.Adjacent(coord2));
Console.WriteLine(coord1.Adjacent(coord3));
Console.WriteLine(coord1.Adjacent(coord4));
Console.WriteLine(coord2.Adjacent(coord5));
Console.WriteLine(coord2.Adjacent(coord6));
Console.WriteLine(coord4.Adjacent(coord6));

public struct Coordinate
{
    private readonly double X { get; init; }
    private readonly double Y { get; init; }

    public Coordinate(double x, double y)
    {
        X = x;
        Y = y;
    }

    public bool Adjacent(Coordinate compared)
    {
        if (compared.X == X - 1 && compared.Y == Y ||
            compared.X == X + 1 && compared.Y == Y ||
            compared.X == X && compared.Y == Y + 1 ||
            compared.X == X && compared.Y == Y - 1)
            return true;

        return false;
    }
}