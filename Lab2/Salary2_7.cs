using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    internal class Salary2_7
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;

        public Salary2_7(double basic, double ta, double da = 0.10, double hra = 0.15)
        {
            Basic = basic;
            TA = ta;
            DA = basic * da;
            HRA = basic * hra;

        }

        public double CalculateTotalSalary()
        {
            return Basic + TA + DA + HRA;
        }

        public void DispalyTotalDetail()
        {
            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("Total Salary: " + CalculateTotalSalary());
        }
    }
}
