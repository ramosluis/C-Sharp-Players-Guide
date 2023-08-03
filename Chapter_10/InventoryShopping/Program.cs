using System.Xml.Serialization;

Console.Write(@"The following items are available:
1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies
What number do you want to see the price of? ");

int item = Convert.ToInt32(Console.ReadLine());

Console.Write("\n\nWhat's your name? ");
string name = Console.ReadLine();
string output;

if (name == "Luis" || name == "luis")
{
    output = item switch
    {
        1 => "Rope costs 5 gold.",
        2 => "Torches cost 7.5 gold.",
        3 => "Climbing equipment costs 12.5 gold.",
        4 => "Clean water costs 0.5 gold.",
        5 => "Machetes cost 10 gold.",
        6 => "Canoes cost 100 gold.",
        7 => "Food supplies cost 0.5 gold.",
        _ => "I don't recognize that item."
    };
}
else
{
    output = item switch
    {
        1 => "Rope costs 10 gold.",
        2 => "Torches cost 15 gold.",
        3 => "Climbing equipment costs 25 gold.",
        4 => "Clean water costs 1 gold.",
        5 => "Machetes cost 20 gold.",
        6 => "Canoes cost 200 gold.",
        7 => "Food supplies cost 1 gold.",
        _ => "I don't recognize that item."
    };
}

Console.WriteLine(output);