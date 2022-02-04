using System;

namespace P08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(GetPower(numberOne, numberTwo));
        }

        private static int GetPower(int numFirst, int numSekond) 
        {
            int totalSum = 1;
            for (int i = 0; i < numSekond; i++)
            {
                totalSum *= numFirst;
            }
            return totalSum;
        }
    }
}
