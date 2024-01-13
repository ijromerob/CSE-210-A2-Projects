using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqnumber = SquareNumber(number);
        DisplayResult(name, sqnumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console. Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number_text = Console.ReadLine();
        int number = int.Parse(number_text);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square_num = number*number;
        return square_num;
    }

    static void DisplayResult(string name, int sqnum)
    {
        Console.WriteLine($"{name}, the Square of your number is {sqnum}");
    }
}