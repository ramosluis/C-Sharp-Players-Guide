int number = AskForNumber("Give me a number!");
Console.WriteLine($"You entered {number}!");
Console.WriteLine("\n\n\n");
int numberInRange = AskForNumberInRange("Give me a number between 1 and 10!", 1, 10);
Console.WriteLine($"You entered {numberInRange}!");


int AskForNumber(string text)
{
    Console.WriteLine(text);
    int returnValue = Convert.ToInt32(Console.ReadLine());
    return returnValue;
}

int AskForNumberInRange(string text, int min, int max)
{
    int returnValue = 0;
    while (true)
    {
        Console.WriteLine(text);
        returnValue = Convert.ToInt32(Console.ReadLine());
        if(returnValue < min || returnValue > max)
        {
            continue;
        }
        break;
    }
    return returnValue;
}