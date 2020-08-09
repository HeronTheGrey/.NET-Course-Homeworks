using System;

namespace Lesson8
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            byte[] tab = new byte[32];
            
            Console.WriteLine("Enter a decimal number.");
            int number;
            int.TryParse(Console.ReadLine(),out number);

            int counter = 0;

            while(number > 0)
            {
                if(number % 2 == 1) {tab[counter] = 1; }
                else { tab[counter] = 0; }
                number = number / 2;
                counter++;
            }

            for(int i = counter - 1; i >= 0; i--)
            {
                Console.Write(tab[i]);
            }
        }
    }
}
