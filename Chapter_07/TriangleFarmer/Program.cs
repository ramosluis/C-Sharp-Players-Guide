Console.WriteLine("Enter base of triangle: ");
float triangleBase = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter height of triangle: ");
float triangleHeight = Convert.ToSingle(Console.ReadLine());

float area = (triangleBase * triangleHeight) / 2;

Console.WriteLine("Area of triangle with a base of " + triangleBase + " and a height of " + triangleHeight + " is: " + area);