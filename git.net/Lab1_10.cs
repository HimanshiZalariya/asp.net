//---------------------10---------------------
Console.WriteLine("Enter first number:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number:");
int c = Convert.ToInt32(Console.ReadLine());

int max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

Console.WriteLine("Maximum number is: " + max);

