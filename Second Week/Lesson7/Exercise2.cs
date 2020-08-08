using System;

namespace Lesson7
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            int a = 5;

            if(a%2==0)
            {
                Console.Write($"{a} jest liczbą parzystą.");
            }
            else
            {
                Console.Write($"{a} jest liczbą nieparzystą.");
            }
        }
    }
}
