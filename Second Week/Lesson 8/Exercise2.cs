using System;

namespace Lesson8
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Those are all even numbers in range 1-1000: ");
            do
            {
                if(i % 2 == 0) { Console.Write($"{i}, "); }
                i++;
            } while (i <= 1000);
        }
    }
}
