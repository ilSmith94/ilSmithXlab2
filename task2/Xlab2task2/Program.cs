using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilSmithXlab2
{
    internal class Program
    {
        class House
        {
            public string city;
            public int housenumbers;

            public void Print()
            {
                Console.WriteLine($"{city}, {housenumbers}");
            }
        }
        static void Main(string[] args)
        {
            House tower = new House();
            tower.city = "Korolev";
            tower.housenumbers = 100500;

            tower.Print();
        }
    }
}