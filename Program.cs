using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1, max = 100, guess, number, guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("\nGuess a number between 1-100:");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < number)
                    {
                        Console.WriteLine("The number is higher than that, enter another guess:");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("The number is lower than that, enter another guess:");
                    }
                    guesses++;
                }

                Console.WriteLine("\nYOU WIN! The number is " + number + "!\n");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("\nWould you like to play again? (Y/N): ");

                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("\nThanks for playing.");
            Console.ReadKey();
        }
    }
}
                
