int[] array = new int[5];

for(int i = 0; i < array.Length; i++)
{
    Console.Write("Enter a number for the array: ");
    int input = Convert.ToInt32(Console.ReadLine());
    array[i] = input;
}

int[] arrayCopy = new int[5];

Console.Clear();

for (int i = 0; i < array.Length; i++)
{
    arrayCopy[i] = array[i];
    Console.WriteLine($"array{i}: {array[i]}");
    Console.WriteLine($"arrayCopy{i}: {arrayCopy[i]}\n");
}