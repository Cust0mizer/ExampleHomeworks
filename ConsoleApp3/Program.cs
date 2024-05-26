using System;

namespace ExampleHomework {
    public class Program {
        public static void Main(string[] args) {
            GetSum(35, 12);
            Print(GetSum(35, 12).ToString());
        }

        private static void Print(string content) {
            Console.WriteLine(content);
        }

        private static int GetSum(int firstValue, int secondValue) {
            return firstValue + secondValue;
        }
    }
}
