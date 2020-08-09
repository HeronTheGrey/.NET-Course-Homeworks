using System;

namespace Lesson7
{
    class Exercise12
    {
        static void Main(string[] args)
        { 
            int day;
            
            Console.WriteLine("Podaj numer dnia tygodnia:");
            int.TryParse(Console.ReadLine(),out day);

            Week tem;

            tem = (Week)day;

            Console.WriteLine(tem);
        }

        public enum Week
        {
            Poniedziałek = 1,
            Wtorek = 2,
            Środa = 3,
            Czwartek = 4,
            Piątek = 5,
            Sobora = 6,
            Niedziela = 7
        }
    }
    }
}
