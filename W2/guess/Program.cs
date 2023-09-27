using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            playAgain = "";
            int guess = 0;
            Random random = new Random();
            int number = random.Next(1, 101);
            int count = 0;
            Console.WriteLine(number);

            while (number != guess)
            {
                count++;

                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("higher");
                }
                else if (guess == number)
                {
                    Console.WriteLine("You guessed  it!");
                    Console.WriteLine($"You did it in {count} guesses");
                }
            }

            Console.Write("Would you like to play again (yes/no)?: ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}
