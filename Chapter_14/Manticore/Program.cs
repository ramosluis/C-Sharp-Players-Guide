int round = 1, cityHealth = 15, maxCityHealth = 15, manticoreHealth = 10, maxManticoreHealth = 10, manticoreDamage = 0, cannonRange = 0;
int manticoreDistance = AskNumberInRange("Player 1, how far away from the city do you want to station the Manticore? ");

Console.Clear();
Console.WriteLine("Player 2, it is your turn.");

while (cityHealth > 0 && manticoreHealth > 0)
{
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/{maxCityHealth} Manticore: {manticoreHealth}/{maxManticoreHealth}");
    manticoreDamage = CannonDamageDealt(round);
    cannonRange = AskNumberInRange("Enter desired cannon range: ");
    CheckForHit(manticoreDistance, cannonRange);

    if (manticoreHealth > 0)
    {
        cityHealth--;
    }

    round++;
}

if(cityHealth <= 0)
    Console.WriteLine("The city of Consolas has been destroyed! The Manticore has been victorious!");
else
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");

int AskNumberInRange(string text)
{
    Console.Write(text);
    int number;
    while(true)
    {
        number = Convert.ToInt32(Console.ReadLine());
        if (number < 0 || number > 100)
        {
            Console.Write("Number not in range, please input a number between 0 and 100: ");
            continue;
        }
        break;
    }

    return number;
}

int CannonDamageDealt(int round)
{
    int damage = 0;
    if (round % 15 == 0)
    {
        damage = 10;
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    else if (round % 5 == 0 )
    {
        damage = 3;
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else if (round % 3 == 0)
    {
        damage = 3;
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        damage = 1;
    }
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    Console.ForegroundColor = ConsoleColor.White;
    return damage;
}

void CheckForHit(int manticoreDistance, int cannonRange)
{
    if(cannonRange > manticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round OVERSHOT the target");
    }
    else if (cannonRange < manticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHealth -= manticoreDamage;
    }
    Console.ForegroundColor = ConsoleColor.White;
}