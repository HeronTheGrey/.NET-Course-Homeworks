using System;

namespace Lesson7
{
    class Exercise8
    {
        static void Main(string[] args)
        {
            int Maths;
            int Chemistry;
            int Physics;
            Console.WriteLine("Wpisz wynik matury z matematyki:");
            int.TryParse(Console.ReadLine(),out Maths);
            Console.WriteLine("Wpisz wynik matury z fizyki:");
            int.TryParse(Console.ReadLine(), out Physics);
            Console.WriteLine("Wpisz wynik matury z chemii:");
            int.TryParse(Console.ReadLine(), out Chemistry);
        
            if((Maths > 70 && Physics > 55 && Chemistry > 45 && Maths + Physics + Chemistry > 180) || (Maths + Physics > 150) || (Maths + Chemistry > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji.");
            }
            
        }
    }
}
