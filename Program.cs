using System;
using System.Collections.Generic;
using System.Linq;
namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What difficulty?");
            Console.WriteLine("Easy = 1");
            Console.WriteLine("Medium = 2");
            Console.WriteLine("Hard = 3");
            int level = Int32.Parse(Console.ReadLine());
            int guesses = 0;
            if (level == 1)
            {
                guesses = 9;
            }else if(level == 2)
            {
                guesses = 7;
            }else if(level == 3)
            {
                guesses = 5;
            }else
            {
                guesses = 2147483647;
            }


            int secretNumber = 42;
            for (int i = 1; i<guesses; i++)
            {
                Console.WriteLine("Guess the secret number!");
                int guess = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Your guess {guess} ({i})");
                if (guess == secretNumber)
                {
                    Console.WriteLine("Success!");
                    Environment.Exit(-1);
                }else if(guess > secretNumber )
                {
                    Console.WriteLine("Too High");
                }else
                {
                    Console.WriteLine("Too Low");
                }
            }


        }
    }
}
