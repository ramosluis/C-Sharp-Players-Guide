Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if ( x < 0 )
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the northwest!");
    }
    else if (y == 0)
    {
        Console.WriteLine("The enemy is to the west!");
    }
    else
    {
        Console.WriteLine("The enemy is to the southwest!");
    }
}
else if (x == 0)
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the north!");
    }
    else if (y == 0)
    {
        Console.WriteLine("The enemy is here!");
    }
    else
    {
        Console.WriteLine("The enemy is to the south!");
    }
}
else
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the northeast!");
    }
    else if (y == 0)
    {
        Console.WriteLine("The enemy is east!");
    }
    else
    {
        Console.WriteLine("The enemy is to the southeast!");
    }
}