using System;

namespace Lesson7
{
    class Exercise6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wzrost:");
            int high;
            int.TryParse(Console.ReadLine(), out high);

            if(high <= 0)
            {
                Console.WriteLine("Wzrost nie może być mniejszy bądź równy zero.");
            }
            else if(high < 170)
            {
                Console.WriteLine("Niski wzrost");
            }
            else if(high < 180)
            {
                Console.WriteLine("Przeciętny wzrost");
            }
            else
            {
                Console.WriteLine("Wysoki wzrost.");
            }
        }
    }
}
