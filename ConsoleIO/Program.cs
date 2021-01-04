using System;
using System.Collections.Generic;

namespace ConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what's your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("How about your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Great, we'll record your name as {firstName} {lastName}.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            //Pause, will not continue until you hit enter.
            //Console.ReadLine();
        }
    }
}
