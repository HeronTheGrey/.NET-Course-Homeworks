using System;

namespace Lesson7
{
    class Exercise8
    {
        static void Main(string[] args)
        {
            int maths;
            int chemistry;
            int physics;
            Console.WriteLine("Wpisz wynik matury z matematyki:");
            int.TryParse(Console.ReadLine(),out maths);
            Console.WriteLine("Wpisz wynik matury z fizyki:");
            int.TryParse(Console.ReadLine(), out physics);
            Console.WriteLine("Wpisz wynik matury z chemii:");
            int.TryParse(Console.ReadLine(), out chemistry);
        
            if((maths > 70 && physics > 55 && chemistry > 45 && maths + physics + chemistry > 180) || (maths + physics > 150) || (maths + chemistry > 150))
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
