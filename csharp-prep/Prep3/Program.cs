using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        int magicNumber;
        int guess;
        Console.Write("What is the magic number? ");    
        string response = Console.ReadLine();
        magicNumber = int.Parse(response);
      
        do
        {

            Console.Write("What is your guess? ");
            response = Console.ReadLine();
            guess = int.Parse(response);

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}