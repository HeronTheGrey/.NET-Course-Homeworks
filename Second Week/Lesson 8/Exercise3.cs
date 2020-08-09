using System;

namespace Lesson8
{
    class Exercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of Fibonacci sentence you want to display.");
            int length;
            int.TryParse(Console.ReadLine(), out length);
            double temp1 = 1;
            double temp2 = 1;
            double temp3 = 0;
            
            if(length == 1)
            {
                Console.Write("1, ");
            }
            else if (length == 2)
            {
                Console.Write("1, 1 ");
            }
            else if (length >= 3)
            {
                Console.Write("1, 1, ");
                for (int i =3; i <= length; i++)
                {
                    temp3 = temp1 + temp2;
                    Console.Write(temp3);
                    Console.Write(", ");
                    temp1 = temp2;
                    temp2 = temp3;
                }
            }
        }
    }
}
