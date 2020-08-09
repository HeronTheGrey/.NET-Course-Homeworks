using System;

namespace Lesson7
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            
            Console.WriteLine("Podaj pierwszą liczbę:");
            double.TryParse(Console.ReadLine(),out firstNumber);


            Console.WriteLine("Podaj drugą liczbę:");
            double.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine("Podaj numer operacji do wykonania:\n" +
                "\t1. Dodawanie\n" +
                "\t2. Odejmowanie\n" +
                "\t3. Mnożenie\n" +
                "\t4. Dzielenie");

            int selectedOption;
            int.TryParse(Console.ReadLine(), out selectedOption);

            switch(selectedOption)
            {
                case 1:
                    Console.WriteLine($"Twój wynik to { firstNumber + secondNumber}." );
                    break;
                case 2:
                    Console.WriteLine($"Twój wynik to { firstNumber - secondNumber}.");
                    break;
                case 3:
                    Console.WriteLine($"Twój wynik to { firstNumber * secondNumber}.");
                    break;
                case 4:
                    if(secondNumber != 0)
                    {
                        Console.WriteLine($"Twój wynik to { firstNumber / secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Nie można mnożyć przez zero!!!");
                    }
                    break;
                default:
                    Console.WriteLine("Wybrano nieprawidłową opcję.");
                    break;
            } 
        }
    }
}
