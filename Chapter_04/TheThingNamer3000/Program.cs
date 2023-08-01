Console.WriteLine("What kind of thing are we talking about?");
/* Store the name of the object in question into variable a */
string a = Console.ReadLine();

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // store the description of the object in b
string c = "of Doom"; // stores a string literal in c
string d = "3000"; // stores a string literal in d

Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");