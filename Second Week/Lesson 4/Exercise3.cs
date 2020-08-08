using System;

namespace Lesson4
{
    class Exercise3
    {
        static void Main(string[] args)
        {

            double high;
            double width;

            Console.WriteLine("Enter the high of the rectangle.(You need to use comma, if you enter a number that is not an integer (e.g. 1,7).)");
            high = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle.(You need to use comma, if you enter a number that is not an integer (e.g. 1,7).)");
            width = double.Parse(Console.ReadLine());

            high = Math.Pow(high, 2);
            width = Math.Pow(width, 2);

            double result = Math.Sqrt(high + width);

            Console.WriteLine($"Diagonal of rectangle is equal to {result}.");

        }
    }
}
