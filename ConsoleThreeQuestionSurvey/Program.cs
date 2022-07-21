using System;

namespace ConsoleThreeQuestionSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age = 0;
            string month = "";
            
            Console.WriteLine("Waht is your name ? ");
            name = Console.ReadLine();

            Console.WriteLine("Waht is your age ? ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Waht is your birth month ? ");
            month = Console.ReadLine();

            Console.WriteLine("Your name is {0}, you are {1} years old and yor birth month is {2} .", name, age, month);


        }
    }
}
