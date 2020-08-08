using System;

namespace Lesson7
{
    class Exercise7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj trzy liczby.");
            int firstNumber;
            int.TryParse(Console.ReadLine(),out firstNumber);
            int secondNumber;
            int.TryParse(Console.ReadLine(),out secondNumber);
            int thirdNumber;
            int.TryParse(Console.ReadLine(),out thirdNumber);
            int max;

            if(firstNumber > secondNumber)
            {
                max = firstNumber;
            }
            else
            {
                max = secondNumber;
            }
            if(max > thirdNumber)
            {
                Console.WriteLine($"{max} jest największa z podanych.");
            }
            else
            {
                Console.WriteLine($"{thirdNumber} jest największa z podanych.");
            }
        }
    }
}
