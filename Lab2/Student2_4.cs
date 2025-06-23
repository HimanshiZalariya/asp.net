using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    internal class Student2_4
    {
        public string Enrollment_No;
        public string Student_Name;
        public int Semester;
        public double CPI;
        public double SPI;

        public Student2_4(string enrollment_No, string student_Name, int semester, double cPI, double sPI)
        {
            Enrollment_No = enrollment_No;
            Student_Name = student_Name;
            Semester = semester;
            CPI = cPI;
            SPI = sPI;
        }


        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Enrollment No: " + Enrollment_No);
            Console.WriteLine("Student Name: " + Student_Name);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("CPI: " + CPI);
            Console.WriteLine("SPI: " + SPI);
        }
    }
}
