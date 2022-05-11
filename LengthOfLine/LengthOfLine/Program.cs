
//UC1
using System;

namespace Line_Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Line Comparision Program");
            Console.WriteLine();
            Console.WriteLine("Enter the coordinates: ");

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            double line1 = Math.Sqrt((Math.Pow((x2 - x1), 2)) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(" length: " + Math.Round(line1, 3));


        }
    }
}

