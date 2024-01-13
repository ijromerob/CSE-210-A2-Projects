using System;

class Program
{
    static void Main(string[] args)
    {
        // this is the input for the first name
        Console.Write("What is your fist name? ");
        string name =Console.ReadLine();
        
        // this is the input for the last name
        Console.Write("What is your last name? ");
        string last_name =Console.ReadLine();

        // it outputs the phrase with the previous information
        Console.WriteLine($"Your name is {last_name}, {name} {last_name}.");
    }
}