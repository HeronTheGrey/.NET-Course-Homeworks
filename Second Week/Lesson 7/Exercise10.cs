using System;

namespace Lesson7
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            bool ind = false;

            Console.WriteLine("Podaj pierwszy bok trójkąta:");
            int.TryParse(Console.ReadLine(),out firstNumber);

            Console.WriteLine("Podaj drugi bok trójkąta:");
            int.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine("Podaj trzeci bok trójkąta:");
            int.TryParse(Console.ReadLine(), out thirdNumber);

            int max;

            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                max = 1;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                max = 2;
            }
            else
            {
                max = 3;
            }

            switch(max)
            {
                case 1:
                    ind = secondNumber + thirdNumber > firstNumber ? true : false;
                    break;
                case 2:
                    ind = firstNumber + thirdNumber > secondNumber ? true : false;
                    break;
                case 3:
                    ind = firstNumber + secondNumber > thirdNumber ? true : false;
                    break;
            }


            if(ind)
            {
                Console.WriteLine("Można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta.");
            }
        }
    }
}
