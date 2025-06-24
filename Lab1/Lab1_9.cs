//---------------------9----------------------

Console.WriteLine("Enter n1 : ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n2 : ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n3 : ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
    Console.WriteLine(n1 + " Is Greater");
else if (n2 > n3)
    Console.WriteLine(n2 + " Is Greater");
else
    Console.WriteLine(n3 + " Is Greater");


