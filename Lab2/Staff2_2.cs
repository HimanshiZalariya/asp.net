using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    internal class Staff2_2
    {
        public string name;
        public string Department;
        public string Designation;
        public int Experience;
        public double Salary;

        public void GetStaff()
        {

            Console.WriteLine("enter a name:");
            name = Console.ReadLine();
            Console.WriteLine("enter a Department:");
            Department = Console.ReadLine();
            Console.WriteLine("enter a Designation :");
            Designation = Console.ReadLine();
            Console.WriteLine("enter a Experience:");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a  Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());


        }

        public void SetDisplay()
        {
            if (Department == "HOD" || Department == "hod")
            {
                Console.WriteLine($" name is :{name}");
                Console.WriteLine($" Experience is :{Salary}");
            }
        }
    }
}
