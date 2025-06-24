
//---------------------8----------------------

Console.WriteLine("Enter First Number : ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number : ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Choice : ");
Console.WriteLine("1.+\n2.-\n3.*\n4./");


char choice = Convert.ToChar(Console.ReadLine());
if (choice == '+')
    Console.WriteLine("Addition : " + (n1 + n2));
else if (choice == '-')
    Console.WriteLine("Subtraction : " + (n1 - n2));
else if (choice == '*')
    Console.WriteLine("Multiplication : " + (n1 * n2));
else if (choice == '/')
    Console.WriteLine("Division : " + (n1 / n2));
else
    Console.WriteLine("Enter valid option");


//----------using switch case---------------


Console.WriteLine("Enter n1 : ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n2 : ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1 add \n2 sub \n3 mul \n4 div");
Console.WriteLine("Enter Choice : ");
char choice = Convert.ToChar(Console.ReadLine());
switch (choice)
{
    case '1':
        Console.WriteLine("Addition : " + (n1 + n2));
        break;

    case '2':
        Console.WriteLine("Subtraction : " + (n1 - n2));
        break;

    case '3':
        Console.WriteLine("Multiplication : " + (n1 * n2));
        break;

    case '4':
        Console.WriteLine("Division : " + (n1 / n2));
        break;

}
