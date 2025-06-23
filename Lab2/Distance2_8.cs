using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    internal class Distance2_8
    {
        public double dis1;
        public double dis2;
        public double dis3;
        public Distance2_8(double d1, double d2)
        {
            dis1 = d1;
            dis2 = d2;
            dis3 = 0;

        }
        public void AddDistance()
        {
            dis3 = dis1 + dis2;
        }

        public void DisplayDistance()
        {
            Console.WriteLine("Distance 1: " + dis1);
            Console.WriteLine("Distance 2: " + dis2);
            Console.WriteLine("Total Distance: " + dis3);
        }
    }
}
