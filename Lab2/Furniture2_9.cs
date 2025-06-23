using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    internal class Furniture2_9
    {
        public string Material;
        public double Price;

        public Furniture2_9(string material, double price)
        {
            Material = material;
            Price = price;

        }

    }
    class Table : Furniture2_9
    {
        public double Heigth;
        public double Surface_area;

        public Table(string material, double price, double heigth, double surface_area) : base(material, price)
        {
            Heigth = heigth;
            Surface_area = surface_area;
        }
        public void DisplayTabInfo()
        {

            Console.WriteLine("Material:" + Material);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Heigth:" + Heigth);
            Console.WriteLine("Surface_area:" + Surface_area);
        }
    }
}
