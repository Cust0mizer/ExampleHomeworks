using System;

namespace ConsoleApp3
{
    class Program
    {



        static double Print(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Print(3.5, 1.2);
        }

        static void Main2()
        {
            string valuea = Console.ReadLine();
            int valueaa = int.Parse(valuea);
            valueaa = +1;
        } 
    }
}
