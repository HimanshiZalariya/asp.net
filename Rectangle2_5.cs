using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Rectangle2_5
    {
        public double Length;
        public double Width;
        public double area;
        public Rectangle2_5(double length, double width)
        {
            Length = length;
            Width = width;

        }
        public void DisplayArea()
        {
            Console.WriteLine($"area of rectangle:{Length * Width}");
        }
    }
}
