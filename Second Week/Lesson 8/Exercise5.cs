using System;

namespace Lesson8
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            int tem = 1;
            int result = 1;
            for(int i = 1; i <= 20; i++)
            {
                result = i;
                tem = i;
                for (int j = 0; j < 2; j++)
                {
                    result = result * tem;
                }
                Console.Write($"{result}, ");
            } 
        }
    }
}
