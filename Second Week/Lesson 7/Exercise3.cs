using System;

namespace Lesson7
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            int a = 14;

            if (a > 0)
            {
                Console.WriteLine($"{a} jest liczbą dodatnią.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} jest liczbą ujemną.");
            }
            else if (a == 0)
            {
                Console.WriteLine($"{a} jest zerem.");
            }
        }
    }
}
