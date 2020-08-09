using System;

namespace Lesson8
{
    class Exercise6
    {
        static void Main(string[] args)
        {
            int tem = 1;
            double result = 0;
            for(int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += 1.0/j ;
                }
                Console.Write($"{result}; ");
                result = 0;
            }
            
        }
    }
}
