//---------------------1----------------------

//Console.WriteLine("xyz abc pqr");
//Console.WriteLine("darshan university");
//Console.WriteLine("1234567892");
//Console.WriteLine("rajkot");

//---------------------2----------------------

//Console.WriteLine("enter a ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter b ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("First Number : " + a);
//Console.WriteLine("Second Number : " + b);

//---------------------3----------------------

//Console.WriteLine("Enter Name : ");
//string name = Convert.ToString(Console.ReadLine());
//Console.WriteLine("Enter countery : ");
//string country = Convert.ToString(Console.ReadLine());
//Console.WriteLine($"hello {name} from countey {country}");

//---------------------4----------------------

//Console.Write("Enter L: ");
//int l = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter  W: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Area : " + (l * b));

//---------------------5----------------------

//Console.WriteLine("enter l1");
//int l1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter b1");
//int b1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("area is rectangle:" + l1 * b1);

//Console.WriteLine("enter l2");
//int l2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("area is square:" + l2 * l2);

//Console.WriteLine("enter r1");
//int r = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("area is circle:" + 3.14 * r * r);

//---------------------6----------------------

//Console.Write("Enter F: ");
//int f = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter  Celsius : ");
//int c = Convert.ToInt32(Console.ReadLine());

//int f2 = (9 / 5) * c + 32;
//int c2 = (f - 32) * 5 / 9;

//Console.WriteLine("F to C : " + c2);
//Console.WriteLine("C to F : " + f2);

//---------------------7----------------------


//Console.WriteLine("Enter P: ");
//int p = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter R: ");
//float r = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter N: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Intrest : " + (p * r * n) / 100);

//---------------------8----------------------

//Console.WriteLine("Enter First Number : ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Second Number : ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Choice : ");
//Console.WriteLine("1.+\n2.-\n3.*\n4./");


//char choice = Convert.ToChar(Console.ReadLine());
//if (choice == '+')
//    Console.WriteLine("Addition : " + (n1 + n2));
//else if (choice == '-')
//    Console.WriteLine("Subtraction : " + (n1 - n2));
//else if (choice == '*')
//    Console.WriteLine("Multiplication : " + (n1 * n2));
//else if (choice == '/')
//    Console.WriteLine("Division : " + (n1 / n2));
//else
//    Console.WriteLine("Enter valid option");


//----------using switch case---------------


//Console.WriteLine("Enter n1 : ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter n2 : ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("1 add \n2 sub \n3 mul \n4 div");
//Console.WriteLine("Enter Choice : ");
//char choice = Convert.ToChar(Console.ReadLine());
//switch (choice)
//{
//    case '1':
//        Console.WriteLine("Addition : " + (n1 + n2));
//        break;

//    case '2':
//        Console.WriteLine("Subtraction : " + (n1 - n2));
//        break;

//    case '3':
//        Console.WriteLine("Multiplication : " + (n1 * n2));
//        break;

//    case '4':
//        Console.WriteLine("Division : " + (n1 / n2));
//        break;

//  }
//---------------------9----------------------

//Console.WriteLine("Enter n1 : ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter n2 : ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter n3 : ");
//int n3 = Convert.ToInt32(Console.ReadLine());

//if (n1 > n2 && n1 > n3)
//    Console.WriteLine(n1 + " Is Greater");
//else if (n2 > n3)
//    Console.WriteLine(n2 + " Is Greater");
//else
//    Console.WriteLine(n3 + " Is Greater");


//---------------------10---------------------
Console.WriteLine("Enter first number:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number:");
int c = Convert.ToInt32(Console.ReadLine());

int max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

Console.WriteLine("Maximum number is: " + max);



