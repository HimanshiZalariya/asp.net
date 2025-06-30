//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab5.Lab_5
//{
//    internal class Student5_2
//    {
//        static void Main(String[] args)
//        {

//            List<String> li = new List<String>();
//            li.Add("abc");
//            li.Add("ghj");
//            li.Add("addf");
//            li.Add("hjk");
//            li.Add("jmn");
//            li.ForEach(Console.WriteLine);

//            Console.WriteLine("after add element ");
//            li.Add("asfd");
//            li.ForEach(Console.WriteLine);

//            Console.WriteLine("after remove element ");
//            li.Remove("abc");
//            li.ForEach(Console.WriteLine);

//            Console.WriteLine("after remove range ");
//            li.RemoveRange(1, 3);
//            li.ForEach(Console.WriteLine);

//            Console.WriteLine("after clear list ");
//            li.Clear();
//            li.ForEach(Console.WriteLine);
//            Console.ReadLine();
//        }

//    }
//}





using System;
using System.Collections;

class List5_2
{
    public void listtmethod()
    {
        List<string> student = new List<string>();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\n1. Add Student\n2. Remove by Index\n3. Remove Range\n4. Clear List\n5. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    student.Add(name);
                    Console.WriteLine("push student:");
                    break;

                case 2:
                    int index = Convert.ToInt32(Console.ReadLine());
                    student.RemoveAt(index);
                    Console.WriteLine("Pop Student:");

                    break;

                case 3:
                    Console.Write("Enter starting index: ");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number of students to remove: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    student.RemoveRange(start, count);
                    Console.WriteLine("Students removed:");

                    break;

                case 4:
                    student.Clear();
                    Console.WriteLine("Clear all student:");
                    break;

                case 5:
                    Console.WriteLine("Exiting");
                    break;

          
            }


            Console.WriteLine("\nStudent List:");
            if (student.Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                int i = 0;
                foreach (string s in student)
                {
                    Console.WriteLine(i + ": " + s);
                    i++;
                }
            }
        }
    }
}



