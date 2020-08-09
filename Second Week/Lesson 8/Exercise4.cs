using System;

namespace Lesson8
{
    class Exercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int number;
            int.TryParse(Console.ReadLine(), out number);

            int counter1 = 0;
            int counter2 = 0;

            if (number >= 1)
            {
                while(counter1 < number)
                {
                    for(int i = 0; i <= counter2; i++)
                    {
                        if (counter1 < number) { Console.Write($"{ counter1 + 1 } "); }
                        counter1++;
                    }
                    counter2++;
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("Entered number must be greater or equal to 1.");
            }
            
        }
    }
}
