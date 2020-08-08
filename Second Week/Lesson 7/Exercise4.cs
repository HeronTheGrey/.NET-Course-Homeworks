using System;

namespace Lesson7
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz rok:");
            int year;
            int.TryParse(Console.ReadLine(), out year);

            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} jest rokiem przestępnym.");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym.");
            }
        }
    }
}
