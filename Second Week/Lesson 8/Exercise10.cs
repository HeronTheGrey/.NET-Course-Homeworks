using System;

namespace Lesson8
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Enter first number");
            int.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter second number");
            int.TryParse(Console.ReadLine(), out secondNumber);

            int lesser;
            int greater;
            int tem = 0;

            if(firstNumber > secondNumber)
            {
                lesser = secondNumber;
                greater = firstNumber;
            }
            else
            {
                greater = secondNumber;
                lesser = firstNumber;
            }

            while (lesser > 0)
            {
                tem = greater % lesser;
                if(tem > lesser)
                {
                    greater = tem;
                }
                else
                {
                    greater = lesser;
                    lesser = tem;
                }
            }
            //Console.WriteLine(greater);
            tem = firstNumber / greater;
            tem *= secondNumber;
            Console.WriteLine($"Greatest common multiple: {tem}");
        }
    }
}
