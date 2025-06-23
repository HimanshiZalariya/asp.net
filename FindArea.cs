using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class FindArea
    {
        public int Farea(int side)
        {
            return side * side;
        }

        public int Farea(int l1, int b1)
        {
            return l1 * b1;
        }
        public double Farea(double radius)
        {
            return 3.14 * radius * radius;
        }
    }
}
