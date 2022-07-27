using System;

namespace HelloWorld
{
class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            //Console.WriteLine("Please enter your name");
            //string? userName = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"I love you so much {userName}");
            //Console.ForegroundColor = ConsoleColor.White;

            // OOP
            Console.WriteLine("What's up");
            Human michael = new Human("Michael", "Goodhorn", "blue", 1);
            Human niklas = new Human("Niklas", "Fischer", "blue", 30);
            michael.IntroduceMyself();
            niklas.IntroduceMyself();

            string[] friends = new string[] { "Sam", "Fabi", "Marcel", "Max" };
            foreach(string friend in friends)
            {
                Console.WriteLine($"How are you doing {friend}?");
            }

            Console.ReadLine();
        }

    }
}