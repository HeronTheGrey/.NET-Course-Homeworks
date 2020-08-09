using System;

namespace Lesson8
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 0; i <= 100; i++)
            {
                counter += IsNumberPrime(i);
            }

            Console.Write($"\nNumber of prime numbers in range 1-100 is equal to {counter}.");
        }

        static int IsNumberPrime(int tested)
        {
            if(tested == 1) { return 0; }
            else if(tested == 2) { Console.Write("2, "); return 1; }
            else if(tested % 2 == 0) { return 0; }
            for (int i = 3; i <= Math.Sqrt(tested); i++)
            {
                if(tested % i == 0) { return 0; }
            }
            Console.Write($"{tested}, ");
            return 1;
        }
    }
}
