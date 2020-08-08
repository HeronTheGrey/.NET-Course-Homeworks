using System;

namespace Lesson7
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            int temperature;
            Console.WriteLine("Podaj temperaturę:");
            int.TryParse(Console.ReadLine(),out temperature);
            
            if(temperature < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if(temperature <= 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temperature <= 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temperature <= 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }

        }
    }
}
