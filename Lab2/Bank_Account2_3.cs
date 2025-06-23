using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    internal class Bank_Account2_3
    {
        public double Account_No;
        public string Email;
        public string User_Name;
        public string Account_Type;
        public double Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("enter a Account_No:");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a Email:");
            Email = Console.ReadLine();
            Console.WriteLine("enter a User_Name :");
            User_Name = Console.ReadLine();
            Console.WriteLine("enter a Account_Type:");
            Account_Type = Console.ReadLine();
            Console.WriteLine("enter a  Account_Balance:");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account_No:{Account_No}");
            Console.WriteLine($"Email:{Email}");
            Console.WriteLine($"User_Name:{User_Name}");
            Console.WriteLine($"Account_Type:{Account_Type}");
            Console.WriteLine($"Account_Balance:{Account_Balance}");
        }

    }
}
