using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a2 = Console.ReadLine();
            int aa2 = int.Parse(a2);
            if (aa2<18)
            {
                Console.WriteLine("ты не годен, иди молоко пей");
            }
            else
            {
                Console.WriteLine("родина ждет");
            }
        }
    }
}
