using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        
        do 
        {
            Random randomGenerator = new Random();
            int magical_number = randomGenerator.Next(1,100);

            Console.Write("What is your guess? ");
            string textvalue2 = Console.ReadLine();
            int guess = int.Parse(textvalue2);
            int count = 1;

            while (guess != magical_number)
            {
                if (guess < magical_number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("What is your guess? ");
                textvalue2 = Console.ReadLine();
                guess = int.Parse(textvalue2);
                count += 1;
            }

            Console.WriteLine("Good job! You got it!");
            Console.WriteLine($"It took you {count} guess(es)");

            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        } while (response == "yes" );

    }
}