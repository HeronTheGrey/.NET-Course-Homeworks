using System;

namespace Lesson8
{
    class Exercise8
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter a sentence.");
            string sent = Console.ReadLine();
            int length = sent.Length;

            for(int i = length - 1; i >= 0; i--)
            {
                Console.Write(sent[i]);
            }
        }
    }
}
