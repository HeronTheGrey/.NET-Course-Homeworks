using System;

namespace Lesson4
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Please enter your phone number");
            ulong phoneNumber;
            ulong.TryParse(Console.ReadLine(),out phoneNumber);
            Console.WriteLine("Please enter your email address");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Please enter your high");
            float high;
            float.TryParse(Console.ReadLine(),out high);
            Console.WriteLine("Please enter your weight");
            float weight;
            float.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("Please enter your age");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Please enter your eye color");
            string eyeColor = Console.ReadLine();
            Console.WriteLine("Please enter your home country");
            string homeCountry = Console.ReadLine();

            Console.Write($"\n\nName: {name}\n" +
                $"Surname: {surname}\n" +
                $"Phone number: {phoneNumber}\n" +
                $"Email address: {emailAddress}\n" +
                $"High: {high}\n" +
                $"Weight: {weight}\n" +
                $"Age: {age}\n" +
                $"Eye color: {eyeColor}\n" +
                $"Home country: {homeCountry}\n");

        }
    }
}
