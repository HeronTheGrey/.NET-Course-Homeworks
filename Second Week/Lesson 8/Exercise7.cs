using System;

namespace Lesson8
{
    class Exercise7
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a width of a diamond(entered value should be an odd number).");
            int width;
            int.TryParse(Console.ReadLine(), out width);


            
            for (int i = 0; i < Math.Ceiling(width/2.0); i++)
            {
                for (int j = 1; j <= (width / 2) - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = width/2-1; i >= 0; i--)
            {
                for (int j = 1; j <= (width / 2) - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            
        }
    }
}
