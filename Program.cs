using static Lab4.AllBank;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a program number:\n1]Areas\n2].Addition\n3].BankRBI\n4].Hospital\n5].FindArea6]BankAccount\n");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Addition addition = new Addition();
                    int add1 = addition.Add(1, 1);
                    float add2 = addition.Add(5.5f, 20.32f);
                    Console.WriteLine(" int number:" + add1);
                    Console.WriteLine(" float number:" + add2);
                    break;


                case 2:
                    Console.WriteLine("enter a value of side:");
                    int side = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter valu of length:");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter value of breadth:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Area area = new Area();
                    int squarearea = area.area(side);
                    int reacarea = area.area(l, b);
                    Console.WriteLine("area of square:" + squarearea);
                    Console.WriteLine("area of rectangle:" + reacarea);
                    break;

                case 3:
                    Console.WriteLine("Enter principal : ");
                    double principal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter rate : ");
                    double rate = Convert.ToDouble(Console.ReadLine());
                    RBI bank;
                    bank = new RBI();
                    bank.CalculateInterest(principal, rate);
                    bank = new HDFC();
                    bank.CalculateInterest(principal, rate);

                    bank = new SBI();
                    bank.CalculateInterest(principal, rate);

                    bank = new ICICI();
                    bank.CalculateInterest(principal, rate);
                    break;

                case 4:
              

                    Hospital hospital;
                    hospital = new Hospital();
                    hospital.HospitalDetails();
                    hospital = new Apollo();
                    hospital.HospitalDetails();
                    hospital = new Wockhardt();
                    hospital.HospitalDetails();
                    hospital = new Gokul_Superspeciality();
                    hospital.HospitalDetails();
                    break;

                case 5:
                    Console.WriteLine("enter a value of side:");
                    int s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter valu of length:");
                    int l1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter value of breadth:");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter a radius");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    FindArea findArea = new FindArea();
                    int squarearea1 = findArea.Farea(s);
                    int reacarea1 = findArea.Farea(l1, b1);
                    double circlearea = findArea.Farea(radius);
                    Console.WriteLine("area of square:" + squarearea1);
                    Console.WriteLine("area of rectangle:" + reacarea1);
                    Console.WriteLine("area of circle:" + circlearea);
                    break;

                case 6:
                    Console.Write("Enter account holder name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter initial balance: ");
                    double iBalance = Convert.ToDouble(Console.ReadLine());

                    BankAccount acc = new BankAccount(name, iBalance);

                    Console.Write("Enter deposit (cash): ");
                    double cashDeposit = Convert.ToDouble(Console.ReadLine());
                    acc.Deposit(cashDeposit);

                    Console.Write("Enter check number to deposit: ");
                    string checkNum = Console.ReadLine();

                    Console.Write("Enter amount to deposit by check: ");
                    double checkDeposit = Convert.ToDouble(Console.ReadLine());
                    acc.Deposit(checkNum, checkDeposit);

                    Console.Write("Enter amount to withdraw (cash): ");
                    double w1 = Convert.ToDouble(Console.ReadLine());
                    acc.Withdraw(w1);

                    Console.Write("Enter check number to withdraw: ");
                    string withdrawCheckNum = Console.ReadLine();

                    Console.Write("Enter amount to withdraw by check: ");
                    double w2 = Convert.ToDouble(Console.ReadLine());
                    acc.Withdraw(withdrawCheckNum, w2);
                    acc.ShowBalance();
                    break;
            }
        }
    }
}
