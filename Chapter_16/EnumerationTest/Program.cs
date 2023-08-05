ChestState state = ChestState.Locked;
string action = "";

while (true)
{
    Console.Write($"The chest is {state}. What do you want to do? ");
    action = Console.ReadLine();

    if (action == "unlock" && state == ChestState.Locked)
    {
        state = ChestState.Closed;
    }
    else if (action == "open" && state == ChestState.Closed)
    {
        state = ChestState.Open;
    }
    else if (action == "close" &&  state == ChestState.Open)
    {
        state = ChestState.Closed;
    }
    else if (action == "lock" && state == ChestState.Closed)
    {
        state = ChestState.Locked;
    }
    else if (action == "quit")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid command");
    }
}



enum ChestState
{
    Open,
    Closed,
    Locked
}