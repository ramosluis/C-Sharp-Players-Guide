﻿Countdown(10);

void Countdown(int number)
{
    if ( number >= 1)
    {
        Console.WriteLine(number);
        Countdown(number - 1);
    }

    return;
}