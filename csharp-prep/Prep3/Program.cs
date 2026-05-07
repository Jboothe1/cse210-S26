using System;

class Program
{
    static void Main(string[] args)
    {
        string jlb_playAgain = "yes";
        Random jlb_randomGenerator = new Random();

        while (jlb_playAgain == "yes")
        {
            int jlb_magicNumber = jlb_randomGenerator.Next(1, 101);
            int jlb_guess = -1;
            int jlb_guessCount = 0;

            while (jlb_guess != jlb_magicNumber)
            {
                Console.Write("What is your guess? ");
                jlb_guess = int.Parse(Console.ReadLine());

                jlb_guessCount++;

                if (jlb_guess < jlb_magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (jlb_guess > jlb_magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {jlb_guessCount} guesses.");

            Console.Write("Do you want to play again? ");
            jlb_playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }
}