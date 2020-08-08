using System;

namespace Lesson7
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            int mark;
            
            Console.WriteLine("Podaj ocenę:");
            int.TryParse(Console.ReadLine(),out mark);

            Marks tem;

            tem = (Marks)mark;

            Console.WriteLine(tem);
        }

        public enum Marks
        {
            Niedostateczny = 1,
            Dopuszczający = 2,
            Dostateczny = 3,
            Dobry = 4,
            Bardzo_dobry = 5,
            Celujący = 6
        }
    }
}
