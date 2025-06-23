using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    

    interface Multiple_inheritance2_10
    {
        void Gross_sal();
    }

    class Employee
    {
        protected string Name;

        public void basic_sal()
        {
            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine();
        }
    }

    class SalaryCal : Employee, Multiple_inheritance2_10
    {
        private double HRA, TA, DA, GrossSalary;

        public void Disp_sal()
        {
            Console.Write("Enter HRA: ");
            HRA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter TA: ");
            TA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter DA: ");
            DA = Convert.ToDouble(Console.ReadLine());
        }

        public void Gross_sal()
        {
            GrossSalary = HRA + TA + DA;
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Gross Salary: " + GrossSalary);
        }
    }
}
