int number = 0, guess = 0;

while (true)
{
    number = AskForNumber("User 1, enter a number between 0 and 100: ");

    if(number < 0 || number > 100)
    {
        Console.WriteLine("Invalid number.");
        continue;
    }

    Console.Clear();
    break;
}

Console.WriteLine("User 2, guess the number.");

while (true)
{
    guess = AskForNumber("What is your next guess? ");

    if (guess > number)
    {
        Console.WriteLine($"{guess} is too high.");
    }
    else if (guess < number)
    {
        Console.WriteLine($"{guess} is too low");
    }
    else
    {
        Console.WriteLine("You guessed the number!");
        break;
    }
}

int AskForNumber(string text)
{
    Console.Write(text);
    int returnValue = Convert.ToInt32(Console.ReadLine());
    return returnValue;
}