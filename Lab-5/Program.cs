using lab5.lab5;
using System;
using System.Collections;
namespace lab5.lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 For Program ArrayList");
            Console.WriteLine("2 For Program List");
            Console.WriteLine("3 For Program Stack");
            Console.WriteLine("4 For Program Queue");
            Console.WriteLine("5 For Program Dict");
            Console.WriteLine("6 For Program Hash");


            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
               
                case 1:
                    Arraylist5_1 arrayListClass = new Arraylist5_1();
                    arrayListClass.arraylist();
                    break;
                case 2:
                    List5_2 listClass = new List5_2();
                    listClass.listtmethod();
                    break;
                case 3:
                    Stack5_3 stackClass = new Stack5_3();
                    stackClass.stackmethod();
                    break;
                case 4:
                    Queue5_4 queueClass = new Queue5_4();
                    queueClass.queuemethod();
                    break;
                case 5:
                    Dictionary5_5 dictionaryClass = new Dictionary5_5();
                    dictionaryClass.Dictionarymethod();
                    break;
                    //case 6:
                    //    HashClass hashClass = new HashClass();
                    //    hashClass.hashmethod();
                    //    break;



            }


        }
    }
}
