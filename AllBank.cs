using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class AllBank
    {
        public class RBI
        {
            public virtual void CalculateInterest(double principal, double time)
            {
                double interest = (principal * time * 3) / 100;
                Console.WriteLine($"Interest calculated by RBI: {interest}");
            }
        }

        public class HDFC : RBI
        {
            public override void CalculateInterest(double principal, double time)
            {
                double interest = (principal * time * 4) / 100;
                Console.WriteLine($"Interest calculated by HDFC: {interest}");
            }
        }

        public class SBI : RBI
        {
            public override void CalculateInterest(double principal, double time)
            {
                double interest = (principal * time * 6) / 100;
                Console.WriteLine($"Interest calculated by SBI: {interest}");
            }
        }

        public class ICICI : RBI
        {
            public override void CalculateInterest(double principal, double time)
            {
                double interest = (principal * time * 5) / 100;
                Console.WriteLine($"Interest calculated by ICICI: {interest}");
            }
        }
    }
}
