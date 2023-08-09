Point pointA = new Point(2, 3);
Point pointB = new Point(-4, 0);
Point pointC = new Point();

Console.WriteLine($"Point A: ({pointA.X}, {pointA.Y})\nPoint B: ({pointB.X}, {pointB.Y})\nPoint C: ({pointC.X}, {pointC.Y})");

public class Point
{
    public int X { get; set; }
    public int Y {  get; set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}