int eggs = 0;

Console.WriteLine("How many chocolate eggs were gathered today?");
eggs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Each sister gets " + eggs / 4 + " eggs.");
Console.WriteLine("Therefore, the duckbear gets " + eggs % 4 + " eggs.");