using System;

namespace Lesson7
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek:");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            if(age < 21)
            {
                Console.WriteLine("Nie możesz zostać posłem.");
            }
            else if(age < 30)
            {
                Console.WriteLine("Możesz zostać posłem lub premierem.");
            }
            else if(age < 35)
            {
                Console.WriteLine("Możesz zostać posłem, premierem lub senatorem.");
            }
            else
            {
                Console.WriteLine("Możesz zostać posłem, premierem, senatorem lub prezydentem.");
            }
        }
    }
}
