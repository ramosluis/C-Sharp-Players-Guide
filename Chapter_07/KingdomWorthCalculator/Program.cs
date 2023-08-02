Console.WriteLine("Enter the number of provinces: ");
int provinces = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of duchies: ");
int duchies  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of estates: ");
int estates  = Convert.ToInt32(Console.ReadLine());

provinces *= 6;
duchies *= 3;

int total = provinces + duchies + estates;

Console.WriteLine("Kingdom total value: " + total);