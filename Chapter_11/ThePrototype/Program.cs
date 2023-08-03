int number = 0, guess = 0;

while (true)
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());

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
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());

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