using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    internal class Candidate2_1
    {
        public int id;
        public string name;
        public int age;
        public double heigth;
        public double weigth;
        public void GetCandidateDetails()
        {
            Console.WriteLine("enter a candidate id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a candidate name:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter a candidate age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a candidate heigth:");
            heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a candidate weigth:");
            weigth = Convert.ToDouble(Console.ReadLine());

        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"candidate id is {id}");
            Console.WriteLine($"candidate name is {name}");
            Console.WriteLine($"candidate age is {age}");
            Console.WriteLine($"candidate heigth is {heigth}");
            Console.WriteLine($"candidate weigth is {weigth}");

        }
    }
}
