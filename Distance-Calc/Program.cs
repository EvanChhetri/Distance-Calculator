// Distance Calculator by Evan C
Console.Clear();
#nullable disable

// Welcome Message
Console.WriteLine("WELCOME TO THE DISTANCE CALCULATOR!");

// Inputs
Console.WriteLine("Enter x1 value: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y1 value: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x2 value: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y2 value: ");
double num4 = Convert.ToDouble(Console.ReadLine());

// Process
double value = Math.Sqrt((Math.Pow((num3 - num1), 2)) + (Math.Pow((num4 - num2), 2)));

// Output
Console.WriteLine($"Distance between the two points is {value}");